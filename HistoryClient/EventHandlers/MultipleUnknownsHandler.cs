using HistoryClient.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryClient
{
    public class MultipleUnknownsHandler
    {
        public static void InviteReuploadRefPhoto(MultipleUnknownPhotosEventArgs e)
        {
            var invReuploadRefForm = new InvitationReuploadRefPhotoForm(e.HowManyUnknownInaRow);
            invReuploadRefForm.ShowDialog();
        }
    }
}
