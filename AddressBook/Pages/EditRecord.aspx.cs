using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AddressBook.Models;
using AddressBook.Models.Repository;

namespace AdressBook.Pages
{
    public partial class EditRecord : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int selectedRecordId;
                if (int.TryParse(Request.QueryString["key"], out selectedRecordId))
                {
                    Record selectedRecord = repository.Records
                        .Where(g => g.Id == selectedRecordId).FirstOrDefault();

                    if (selectedRecord != null)
                    {
                        lbl_id.Text = selectedRecord.Id.ToString();
                        tbox_FirstName.Text = selectedRecord.FirstName;
                        tbox_MiddleName.Text = selectedRecord.MiddleName;
                        tbox_LastName.Text = selectedRecord.LastName;
                        tbox_Email.Text = selectedRecord.Email;
                        tbox_Phone.Text = selectedRecord.Phone;
                    }
                }
            }
            
        }
        protected void btn_Save_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            int id;
            if (int.TryParse(lbl_id.Text, out id))
                record.Id = id;
            else
                record.Id = 0;  
            record.FirstName = tbox_FirstName.Text;
            record.MiddleName = tbox_MiddleName.Text;
            record.LastName = tbox_LastName.Text;
            record.Email = tbox_Email.Text;
            record.Phone = tbox_Phone.Text;

            repository.SaveRecord(record);
            Response.Redirect("~/Pages/Listing.aspx");
        }
    }
}