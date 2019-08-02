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
    public partial class Listing : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<Record> GetRecords()
        {
            return repository.Records;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int selectedGameId;
                if (int.TryParse(Request.Form["delete"], out selectedGameId))
                {
                    Record selectedRecord = repository.Records
                        .Where(g => g.Id == selectedGameId).FirstOrDefault();

                    if (selectedRecord != null)
                    {
                        repository.DeleteRecord(selectedRecord);
                    }
                }
                if (int.TryParse(Request.Form["edit"], out selectedGameId))
                {
                    Record selectedRecord = repository.Records
                        .Where(g => g.Id == selectedGameId).FirstOrDefault();

                    if (selectedRecord != null)
                    {
                        Response.Redirect("~/Pages/EditRecord.aspx?key=" + selectedGameId);
                    }
                }
            }
        }
        //protected btn_delete_Click
    }
}