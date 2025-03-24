using SourceData.Data;
using SourceData.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceData
{
    public partial class Form1: Form
    {
        SourceDBContext dbContext = new SourceDBContext();

		public Form1()
        {
            InitializeComponent();
        }

		private void Form1_Load(object sender, EventArgs e)
		{
			this.ClearForm();
			this.LoadData();
		}

		private void LoadData()
        {
			lstContacts.Items.Clear();
			var contacts = dbContext.Contacts;
			foreach (var contact in contacts)
			{
				lstContacts.Items.Add(
					new ListViewItem(new[]
					{
						contact.Id.ToString(),
						contact.FirstName,
						contact.LastName,
						contact.Email,
						contact.IsSent.ToString(),
					}));
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.CheckControls())
			{
				dbContext.Contacts.Add(
					new Contact
					{
						Id = (int)numId.Value,
						FirstName = txtFirstName.Text,
						LastName = txtLastName.Text,
						Email	= txtEmail.Text,
					});
				dbContext.SaveChanges();
				this.LoadData();

				this.ClearForm();
				hintLabel.Text = "Record added into local database...";
			}
		}

		private void ClearForm()
		{
			this.InitId();
			txtFirstName.Text = string.Empty;
			txtLastName.Text = string.Empty;
			txtEmail.Text = string.Empty;
			txtFirstName.Focus();
		}

		private void InitId()
		{
			if (dbContext.Contacts.ToList().Count > 0)
			{
				numId.Value = dbContext.Contacts.Max(x => x.Id) + 1;
			}
			else
			{
				numId.Value = 1;
			}
		}

		private bool CheckControls()
		{
			if (string.IsNullOrWhiteSpace(txtFirstName.Text))
			{
				txtFirstName.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{
				txtLastName.Focus();
				return false;
			}
			if (string.IsNullOrWhiteSpace(txtEmail.Text))
			{
				txtEmail.Focus();
				return false;
			}
			return true;
		}

		private async void btnSynchronize_Click(object sender, EventArgs e)
		{
			var unsentContacts = dbContext.Contacts.Where(x => !x.IsSent).ToList();
			if (unsentContacts.Count <= 0) return;
			
			if (await new DataSender().SendData(unsentContacts))
			{
				var ids = unsentContacts.Select(x => x.Id).ToHashSet();
				await UpdateRecords(ids);
				LoadData();

				hintLabel.Text = $"{unsentContacts.Count} record(s) sent ...";
			}
		}

		private async Task UpdateRecords(HashSet<int> ids)
		{
			var contacts = dbContext.Contacts.Where(x => ids.Contains(x.Id)).ToList();
			contacts.ForEach(x => x.IsSent = true);
			await dbContext.SaveChangesAsync();
		}
	}
}
