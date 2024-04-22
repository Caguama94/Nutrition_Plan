namespace Programa_Dieta
{
    partial class ListaDeCompra
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
            copiarListaMandadoButton = new Button();
            resumenListBox = new ListBox();
            listaDeCompraLabel = new Label();
            huevoLabel = new Label();
            totalHuevoLabel = new Label();
            totalChorizoLabel = new Label();
            chorizoLabel = new Label();
            SuspendLayout();
            // 
            // copiarListaMandadoButton
            // 
            copiarListaMandadoButton.BackColor = Color.MediumSpringGreen;
            copiarListaMandadoButton.Font = new Font("Roboto", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            copiarListaMandadoButton.Location = new Point(623, 362);
            copiarListaMandadoButton.Name = "copiarListaMandadoButton";
            copiarListaMandadoButton.Size = new Size(165, 42);
            copiarListaMandadoButton.TabIndex = 6;
            copiarListaMandadoButton.Text = "Copiar la lista de compra";
            copiarListaMandadoButton.UseVisualStyleBackColor = false;
            // 
            // resumenListBox
            // 
            resumenListBox.FormattingEnabled = true;
            resumenListBox.ItemHeight = 15;
            resumenListBox.Items.AddRange(new object[] { "Frutas y verduras:", "- Tomate 150 gr.", "- Lechuga 350 gr.", "- Papa 450 gr.", "- Cebolla 700 gr.", "- Manzana 450 gr.", "- Platano 250 gr.", "- Fresa 500 gr.", "", "Perecederos:", "- Pechuga de pollo con hueso 900 gr.", "- Pechuga de pollo sin hueso 600 gr.", "- Chuleta de cerdo ahumada 450 gr.", "- Milanesa de res 500 gr.", "- Huevo 20 pzas.", "- Leche 4 litros.", "- Tortillas 500 gr.", "- Queso 450 gr." });
            resumenListBox.Location = new Point(434, 22);
            resumenListBox.Name = "resumenListBox";
            resumenListBox.Size = new Size(354, 334);
            resumenListBox.TabIndex = 5;
            // 
            // listaDeCompraLabel
            // 
            listaDeCompraLabel.AutoSize = true;
            listaDeCompraLabel.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point);
            listaDeCompraLabel.Location = new Point(2, 9);
            listaDeCompraLabel.Name = "listaDeCompraLabel";
            listaDeCompraLabel.Size = new Size(372, 58);
            listaDeCompraLabel.TabIndex = 4;
            listaDeCompraLabel.Text = "Lista de compra";
            // 
            // huevoLabel
            // 
            huevoLabel.AutoSize = true;
            huevoLabel.Font = new Font("Roboto Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            huevoLabel.Location = new Point(12, 67);
            huevoLabel.Name = "huevoLabel";
            huevoLabel.Size = new Size(62, 22);
            huevoLabel.TabIndex = 7;
            huevoLabel.Text = "Huevo";
            // 
            // totalHuevoLabel
            // 
            totalHuevoLabel.AutoSize = true;
            totalHuevoLabel.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalHuevoLabel.Location = new Point(12, 89);
            totalHuevoLabel.Name = "totalHuevoLabel";
            totalHuevoLabel.Size = new Size(49, 14);
            totalHuevoLabel.TabIndex = 8;
            totalHuevoLabel.Text = "gramos";
            // 
            // totalChorizoLabel
            // 
            totalChorizoLabel.AutoSize = true;
            totalChorizoLabel.Font = new Font("Roboto", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalChorizoLabel.Location = new Point(12, 125);
            totalChorizoLabel.Name = "totalChorizoLabel";
            totalChorizoLabel.Size = new Size(49, 14);
            totalChorizoLabel.TabIndex = 10;
            totalChorizoLabel.Text = "gramos";
            // 
            // chorizoLabel
            // 
            chorizoLabel.AutoSize = true;
            chorizoLabel.Font = new Font("Roboto Black", 13F, FontStyle.Regular, GraphicsUnit.Point);
            chorizoLabel.Location = new Point(12, 103);
            chorizoLabel.Name = "chorizoLabel";
            chorizoLabel.Size = new Size(73, 22);
            chorizoLabel.TabIndex = 9;
            chorizoLabel.Text = "Chorizo";
            // 
            // ListaDeCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 423);
            Controls.Add(totalChorizoLabel);
            Controls.Add(chorizoLabel);
            Controls.Add(totalHuevoLabel);
            Controls.Add(huevoLabel);
            Controls.Add(copiarListaMandadoButton);
            Controls.Add(resumenListBox);
            Controls.Add(listaDeCompraLabel);
            Name = "ListaDeCompra";
            Text = "ListaDeCompra";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button copiarListaMandadoButton;
        private ListBox resumenListBox;
        private Label listaDeCompraLabel;
        private Label huevoLabel;
        private Label totalHuevoLabel;
        private Label totalChorizoLabel;
        private Label chorizoLabel;
    }
}