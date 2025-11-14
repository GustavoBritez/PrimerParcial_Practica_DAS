namespace Ejerciotacion_AdoDesconectado
{
    partial class Form1
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
            Grilla_Usuarios = new DataGridView();
            label1 = new Label();
            BTN_ELIMINAR_USUARIO = new Button();
            BTN_AGREGAR_USUARIO = new Button();
            BTN_MODIFICAR_USUARIO = new Button();
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuarios).BeginInit();
            SuspendLayout();
            // 
            // Grilla_Usuarios
            // 
            Grilla_Usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla_Usuarios.Location = new Point(12, 37);
            Grilla_Usuarios.Name = "Grilla_Usuarios";
            Grilla_Usuarios.Size = new Size(206, 87);
            Grilla_Usuarios.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuarios";
            // 
            // BTN_ELIMINAR_USUARIO
            // 
            BTN_ELIMINAR_USUARIO.Location = new Point(224, 72);
            BTN_ELIMINAR_USUARIO.Name = "BTN_ELIMINAR_USUARIO";
            BTN_ELIMINAR_USUARIO.Size = new Size(75, 23);
            BTN_ELIMINAR_USUARIO.TabIndex = 2;
            BTN_ELIMINAR_USUARIO.Text = "Eliminar";
            BTN_ELIMINAR_USUARIO.UseVisualStyleBackColor = true;
            // 
            // BTN_AGREGAR_USUARIO
            // 
            BTN_AGREGAR_USUARIO.Location = new Point(224, 43);
            BTN_AGREGAR_USUARIO.Name = "BTN_AGREGAR_USUARIO";
            BTN_AGREGAR_USUARIO.Size = new Size(75, 23);
            BTN_AGREGAR_USUARIO.TabIndex = 2;
            BTN_AGREGAR_USUARIO.Text = "Agregar";
            BTN_AGREGAR_USUARIO.UseVisualStyleBackColor = true;
            BTN_AGREGAR_USUARIO.Click += BTN_AGREGAR_USUARIO_Click;
            // 
            // BTN_MODIFICAR_USUARIO
            // 
            BTN_MODIFICAR_USUARIO.Location = new Point(224, 101);
            BTN_MODIFICAR_USUARIO.Name = "BTN_MODIFICAR_USUARIO";
            BTN_MODIFICAR_USUARIO.Size = new Size(75, 23);
            BTN_MODIFICAR_USUARIO.TabIndex = 3;
            BTN_MODIFICAR_USUARIO.Text = "Modificar";
            BTN_MODIFICAR_USUARIO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 374);
            Controls.Add(BTN_MODIFICAR_USUARIO);
            Controls.Add(BTN_AGREGAR_USUARIO);
            Controls.Add(BTN_ELIMINAR_USUARIO);
            Controls.Add(label1);
            Controls.Add(Grilla_Usuarios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla_Usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Grilla_Usuarios;
        private Label label1;
        private Button BTN_ELIMINAR_USUARIO;
        private Button BTN_AGREGAR_USUARIO;
        private Button BTN_MODIFICAR_USUARIO;
    }
}
