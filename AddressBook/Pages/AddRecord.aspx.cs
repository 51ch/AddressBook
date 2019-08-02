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
    public partial class AddRecord : System.Web.UI.Page
    {
        private Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {
        } 

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            Record record = new Record();
            record.Id = 0; //нулевой id, чтобы запись отправилась в базу через context.add и автоматически получила свободный id
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