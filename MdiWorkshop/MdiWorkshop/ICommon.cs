/**
 * Brice Allard
 * Contemporary Programming - C#
 * Dr. Stringfellow
 * 11-27-2018
 * 
 * Inventory Solution Software designed with MDI in mind. One parent form
 * and multiple child forms to maintain the inventory of several locations
 * at once. Menu items are demonstrated as well as sort and serialization
 * for easy data management and file storage.
 **/

using System;

namespace MdiWorkshop
{
    /// <summary>
    /// Interface class to share through project allowing multiple Children
    /// to call on functions from other either the Parent or another Child
    /// </summary>
    interface ICommon
    {
        void Save();
        void BTN_Insert_Click(object sender, EventArgs e);
        void BTN_Delete_Click(object sender, EventArgs e);
        void BTN_Edit_Click(object sender, EventArgs e);
    }
}
