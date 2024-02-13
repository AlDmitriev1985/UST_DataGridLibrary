using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UST_DataGridLibrary
{
    public static class Methodes
    {
        /// <summary>
        /// Применение стандартных настроек
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="columns"></param>
        public static void CreateDataGrid(DataGridView dataGridView, List<string> columns)
        {
            for (int i = 0; i < columns.Count; i++)
            {
                dataGridView.Columns.Add($"Column{i}", columns[i]);
                dataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.FixedSingle;

            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = false;

            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersHeight = 35;

            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;

            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(16, 110, 190);
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView.MultiSelect = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;

        }

        public static void ApplyRowBackColor(DataGridViewRow row, Color color)
        {
            foreach(DataGridViewCell cell in row.Cells)
            {
                cell.Style.BackColor = color;
            }
        }
    }
}
