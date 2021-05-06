
namespace LessonsPlan
{
    partial class FormShedule
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridWeek = new System.Windows.Forms.DataGridView();
            this.co_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.co_day7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridWeek)).BeginInit();
            this.SuspendLayout();
            // 
            // GridWeek
            // 
            this.GridWeek.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridWeek.BackgroundColor = System.Drawing.Color.White;
            this.GridWeek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridWeek.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.co_time,
            this.co_day1,
            this.co_day2,
            this.co_day3,
            this.co_day4,
            this.co_day5,
            this.co_day6,
            this.co_day7});
            this.GridWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridWeek.Location = new System.Drawing.Point(0, 0);
            this.GridWeek.Name = "GridWeek";
            this.GridWeek.RowHeadersWidth = 51;
            this.GridWeek.RowTemplate.Height = 29;
            this.GridWeek.Size = new System.Drawing.Size(925, 450);
            this.GridWeek.TabIndex = 0;
            this.GridWeek.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridWeek_CellEndEdit);
            // 
            // co_time
            // 
            this.co_time.HeaderText = "Время";
            this.co_time.MinimumWidth = 6;
            this.co_time.Name = "co_time";
            this.co_time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day1
            // 
            this.co_day1.HeaderText = "Понедельник";
            this.co_day1.MinimumWidth = 6;
            this.co_day1.Name = "co_day1";
            this.co_day1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day2
            // 
            this.co_day2.HeaderText = "Вторник";
            this.co_day2.MinimumWidth = 6;
            this.co_day2.Name = "co_day2";
            this.co_day2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day3
            // 
            this.co_day3.HeaderText = "Среда";
            this.co_day3.MinimumWidth = 6;
            this.co_day3.Name = "co_day3";
            this.co_day3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day4
            // 
            this.co_day4.HeaderText = "Четеврг";
            this.co_day4.MinimumWidth = 6;
            this.co_day4.Name = "co_day4";
            this.co_day4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day5
            // 
            this.co_day5.HeaderText = "Пятница";
            this.co_day5.MinimumWidth = 6;
            this.co_day5.Name = "co_day5";
            this.co_day5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day6
            // 
            this.co_day6.HeaderText = "Суббота";
            this.co_day6.MinimumWidth = 6;
            this.co_day6.Name = "co_day6";
            this.co_day6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // co_day7
            // 
            this.co_day7.HeaderText = "Восресенье";
            this.co_day7.MinimumWidth = 6;
            this.co_day7.Name = "co_day7";
            this.co_day7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FormShedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.GridWeek);
            this.Name = "FormShedule";
            this.ShowIcon = false;
            this.Text = "Расписание занятий";
            ((System.ComponentModel.ISupportInitialize)(this.GridWeek)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day1;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day2;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day3;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day4;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day5;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day6;
        private System.Windows.Forms.DataGridViewTextBoxColumn co_day7;
    }
}

