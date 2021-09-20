
namespace LinqMethods
{
    partial class UserListForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserList = new System.Windows.Forms.ListBox();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserList
            // 
            this.UserList.FormattingEnabled = true;
            this.UserList.ItemHeight = 16;
            this.UserList.Location = new System.Drawing.Point(37, 117);
            this.UserList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(376, 212);
            this.UserList.TabIndex = 0;
            this.UserList.SelectedIndexChanged += new System.EventHandler(this.UserList_SelectedIndexChanged);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(37, 41);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(376, 22);
            this.TxtBuscar.TabIndex = 1;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar:";
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.UserList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:: User List ::..";
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox UserList;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Label label1;
    }
}

