namespace GeometriaDekstop
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox3 = new GroupBox();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 42);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Ancho";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 76);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Alto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 114);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Radio";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(268, 146);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(18, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(671, 615);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de la Figura";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(38, 45);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 272);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de figura";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(105, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Rectangulo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(22, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(76, 24);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Circulo";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(484, 39);
            button1.Name = "button1";
            button1.Size = new Size(112, 67);
            button1.TabIndex = 5;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(484, 123);
            button2.Name = "button2";
            button2.Size = new Size(112, 67);
            button2.TabIndex = 6;
            button2.Text = "Confirmar Registro";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(97, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(325, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(97, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(325, 111);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(97, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(325, 146);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(97, 27);
            textBox4.TabIndex = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView3);
            groupBox3.Controls.Add(listView2);
            groupBox3.Controls.Add(listView1);
            groupBox3.Location = new Point(60, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(391, 327);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Liatado de Figuras";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(308, 84);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(6, 132);
            listView2.Name = "listView2";
            listView2.Size = new Size(308, 84);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(6, 222);
            listView3.Name = "listView3";
            listView3.Size = new Size(308, 84);
            listView3.TabIndex = 2;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(466, 310);
            button3.Name = "button3";
            button3.Size = new Size(112, 67);
            button3.TabIndex = 11;
            button3.Text = "Actualizar Listado";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(466, 417);
            button4.Name = "button4";
            button4.Size = new Size(112, 67);
            button4.TabIndex = 12;
            button4.Text = "Eliminar Registro";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 638);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox3;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private ListView listView3;
        private ListView listView2;
        private ListView listView1;
        private Button button4;
        private Button button3;
    }
}
