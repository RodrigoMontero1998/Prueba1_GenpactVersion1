
namespace Proyecto1
{
    partial class Nuevo
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
            this.components = new System.ComponentModel.Container();
            this.ConsolidateBtn = new System.Windows.Forms.Button();
            this.ChoiseFolderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPath = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ConsolidateBtn
            // 
            this.ConsolidateBtn.Location = new System.Drawing.Point(686, 451);
            this.ConsolidateBtn.Name = "ConsolidateBtn";
            this.ConsolidateBtn.Size = new System.Drawing.Size(150, 31);
            this.ConsolidateBtn.TabIndex = 0;
            this.ConsolidateBtn.Text = "Consolidar";
            this.ConsolidateBtn.UseVisualStyleBackColor = true;
            this.ConsolidateBtn.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // ChoiseFolderBtn
            // 
            this.ChoiseFolderBtn.Location = new System.Drawing.Point(692, 362);
            this.ChoiseFolderBtn.Name = "ChoiseFolderBtn";
            this.ChoiseFolderBtn.Size = new System.Drawing.Size(144, 31);
            this.ChoiseFolderBtn.TabIndex = 1;
            this.ChoiseFolderBtn.Text = "Seleccionar carpeta";
            this.ChoiseFolderBtn.UseVisualStyleBackColor = true;
            this.ChoiseFolderBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directorio";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(93, 366);
            this.textPath.Name = "textPath";
            this.textPath.ReadOnly = true;
            this.textPath.Size = new System.Drawing.Size(593, 22);
            this.textPath.TabIndex = 3;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList;
            this.listView.Location = new System.Drawing.Point(15, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(843, 315);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 508);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChoiseFolderBtn);
            this.Controls.Add(this.ConsolidateBtn);
            this.Name = "Nuevo";
            this.Text = "Consolidador de Excel";
            this.Load += new System.EventHandler(this.Nuevo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConsolidateBtn;
        private System.Windows.Forms.Button ChoiseFolderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ListView listView;
    }
}

