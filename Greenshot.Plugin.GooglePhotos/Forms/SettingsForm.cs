/*
 * A GooglePhotos Plugin for Greenshot
 * Copyright (C) 2011  Francis Noel
 * 
 * For more information see: https://getgreenshot.org/
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 1 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */

namespace Greenshot.Plugin.GooglePhotos.Forms
{
    /// <summary>
    /// Description of PasswordRequestForm.
    /// </summary>
    public partial class SettingsForm : GooglePhotosForm
    {
        public SettingsForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            CancelButton = buttonCancel;
            AcceptButton = buttonOK;
        }
    }
}