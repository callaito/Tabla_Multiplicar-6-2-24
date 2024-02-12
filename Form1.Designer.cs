namespace Tabla_Multiplicar_6_2_24
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
            txt_Numero=new TextBox();
            btn_Salir=new Button();
            lbl_Ingresar_Numero=new Label();
            btn_Mostrar=new Button();
            lst_Tabla=new ListBox();
            SuspendLayout();
            // 
            // txt_Numero
            // 
            txt_Numero.Location=new Point(476, 81);
            txt_Numero.Name="txt_Numero";
            txt_Numero.Size=new Size(100, 23);
            txt_Numero.TabIndex=0;
            // 
            // btn_Salir
            // 
            btn_Salir.Location=new Point(696, 124);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(75, 23);
            btn_Salir.TabIndex=1;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=true;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // lbl_Ingresar_Numero
            // 
            lbl_Ingresar_Numero.AutoSize=true;
            lbl_Ingresar_Numero.Location=new Point(476, 35);
            lbl_Ingresar_Numero.Name="lbl_Ingresar_Numero";
            lbl_Ingresar_Numero.Size=new Size(98, 15);
            lbl_Ingresar_Numero.TabIndex=2;
            lbl_Ingresar_Numero.Text="Ingresar_Numero";
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.Location=new Point(696, 80);
            btn_Mostrar.Name="btn_Mostrar";
            btn_Mostrar.Size=new Size(75, 23);
            btn_Mostrar.TabIndex=3;
            btn_Mostrar.Text="Mostrar";
            btn_Mostrar.UseVisualStyleBackColor=true;
            btn_Mostrar.Click+=btn_Mostrar_Click;
            // 
            // lst_Tabla
            // 
            lst_Tabla.FormattingEnabled=true;
            lst_Tabla.ItemHeight=15;
            lst_Tabla.Location=new Point(12, 14);
            lst_Tabla.Name="lst_Tabla";
            lst_Tabla.Size=new Size(407, 334);
            lst_Tabla.TabIndex=4;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(lst_Tabla);
            Controls.Add(btn_Mostrar);
            Controls.Add(lbl_Ingresar_Numero);
            Controls.Add(btn_Salir);
            Controls.Add(txt_Numero);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Numero;
        private Button btn_Salir;
        private Label lbl_Ingresar_Numero;
        private Button btn_Mostrar;
        private ListBox lst_Tabla;
    }
}