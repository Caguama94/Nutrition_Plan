namespace Programa_Dieta
{
    partial class ResumenPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            resumenLabel = new Label();
            resumenListBox = new ListBox();
            resumenConfirmarButton = new Button();
            SuspendLayout();
            // 
            // resumenLabel
            // 
            resumenLabel.AutoSize = true;
            resumenLabel.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            resumenLabel.Location = new Point(12, 9);
            resumenLabel.Name = "resumenLabel";
            resumenLabel.Size = new Size(652, 58);
            resumenLabel.TabIndex = 0;
            resumenLabel.Text = "Resumen de plan alimenticio";
            // 
            // resumenListBox
            // 
            resumenListBox.FormattingEnabled = true;
            resumenListBox.ItemHeight = 15;
            resumenListBox.Items.AddRange(new object[] { "Desayunos ", "Lunes chilaquiles", "", "Martes chilaquiles ", "", "Miércoles huevo con chorizo ", "", "Jueves cereal con leche y plátano ", "", "Viernes moyetes ", "", "", "", "Comidas", "", "", "Lunes ensalada de atún ", "", "Martes pollo enchilado con spaghetti verde ", "", "Miércoles tacos de vampiros con quesadillas y salchicha de asar ", "", "Jueves spaguetti a la bolognese ", "", "Viernes tacos sudados ", "", "", "", "Cenas ", "", "", "Lunes cereal ", "", "Martes huevo y licuado ", "", "Miércoles quesadillas ", "", "Jueves gorditas baratas" });
            resumenListBox.Location = new Point(12, 70);
            resumenListBox.Name = "resumenListBox";
            resumenListBox.Size = new Size(228, 619);
            resumenListBox.TabIndex = 1;
            // 
            // resumenConfirmarButton
            // 
            resumenConfirmarButton.BackColor = Color.MediumSpringGreen;
            resumenConfirmarButton.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            resumenConfirmarButton.Location = new Point(644, 647);
            resumenConfirmarButton.Name = "resumenConfirmarButton";
            resumenConfirmarButton.Size = new Size(165, 42);
            resumenConfirmarButton.TabIndex = 3;
            resumenConfirmarButton.Text = "Confirmar plan alimenticio";
            resumenConfirmarButton.UseVisualStyleBackColor = false;
            resumenConfirmarButton.Click += resumenConfirmarButton_Click;
            // 
            // ResumenPlan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 693);
            Controls.Add(resumenConfirmarButton);
            Controls.Add(resumenListBox);
            Controls.Add(resumenLabel);
            Name = "ResumenPlan";
            Text = "ResumenPlan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resumenLabel;
        private ListBox resumenListBox;
        private Button resumenConfirmarButton;
    }
}