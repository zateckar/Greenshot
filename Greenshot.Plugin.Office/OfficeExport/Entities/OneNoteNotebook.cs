// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2021 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: https://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <https://www.gnu.org/licenses/>.

namespace Greenshot.Plugin.Office.OfficeExport.Entities
{
    /// <summary>
    ///     Container for transporting notebook information
    /// </summary>
    public class OneNoteNotebook
    {
        /// <summary>
        /// ID of the notebook
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Name of the notebook
        /// </summary>
        public string Name { get; set; }
    }
}