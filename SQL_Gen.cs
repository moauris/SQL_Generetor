using System;
using System.Linq;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SQL_Gen
{
    public class Form1 : Form
    {
        String Version_info = "SQL Generator v0.1.000";
        Label label1 = new Label();
        Label label2 = new Label();
        CheckBox checkBox3 = new CheckBox();
        CheckBox checkBox4 = new CheckBox();
        CheckBox checkBox5 = new CheckBox();
        CheckBox checkBox6 = new CheckBox();
        CheckBox checkBox7 = new CheckBox();
        CheckBox checkBox8 = new CheckBox();
        CheckBox checkBox9 = new CheckBox();
        CheckBox checkBox10 = new CheckBox();
        CheckBox checkBox11 = new CheckBox();
        Label label3 = new Label();
        TextBox textBox1 = new TextBox();
        Label label4 = new Label();
        RadioButton radioButton1 = new RadioButton();
        RadioButton radioButton2 = new RadioButton();
        Button button1 = new Button();
        TextBox textBox2 = new TextBox();
        Button button2 = new Button();
        TextBox textBox3 = new TextBox();
        CheckBox checkBox1 = new CheckBox();
        TextBox textBox4 = new TextBox();
        Label label5 = new Label();
        //Below Codes hide Console Window
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        public Form1()
            : base()
        {
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.AutoSize = true;
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(130, 13);
            label1.TabIndex = 0;
            label1.Text = "Select Your Inquery Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 49);
            label2.Name = "label2";
            label2.Size = new Size(103, 13);
            label2.TabIndex = 0;
            label2.Text = "Select Data Center: ";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(26, 272);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(97, 17);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Output as File: ";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += new System.EventHandler(checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(26, 73);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(73, 17);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "uny30110";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(150, 73);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(73, 17);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "uny40110";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(274, 73);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(73, 17);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "uny40310";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(398, 73);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(73, 17);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "uny40510";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(26, 97);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(73, 17);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "uny40710";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(150, 97);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(73, 17);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "uny40910";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(274, 97);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(73, 17);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "uny41110";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(398, 97);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(73, 17);
            checkBox11.TabIndex = 9;
            checkBox11.Text = "uny41310";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 127);
            label3.Name = "label3";
            label3.Size = new Size(58, 13);
            label3.TabIndex = 0;
            label3.Text = "Parameter:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(26, 149);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 105);
            textBox1.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 299);
            label4.Name = "label4";
            label4.Size = new Size(45, 13);
            label4.TabIndex = 0;
            label4.Text = "Results:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(160, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(92, 17);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "M/Agent Jobs";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += new System.EventHandler(radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(251, 16);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 17);
            radioButton2.TabIndex = 11;
            radioButton2.TabStop = true;
            radioButton2.Text = "Shout Setting";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += new System.EventHandler(radioButton2_CheckedChanged);
            // 
            // button1
            // 
            button1.Location = new Point(355, 262);
            button1.Name = "button1";
            button1.Size = new Size(118, 34);
            button1.TabIndex = 12;
            button1.Text = "Generate SQL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_click);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 315);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 244);
            textBox2.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(355, 566);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 12;
            button2.Text = "Copy to Clipboard";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(120, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(168, 20);
            textBox3.TabIndex = 13;
            textBox3.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(150, 48);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(70, 17);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Select All";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += new System.EventHandler(checkBox1_click);
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(26, 574);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 20);
            textBox4.TabIndex = 13;
            textBox4.Text = "Ready.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(290, 272);
            label5.Name = "label5";
            label5.Size = new Size(23, 13);
            label5.TabIndex = 14;
            label5.Text = ".sql";
            label5.Visible = false;
            // 
            // Form1
            // 
            this.Text = Version_info;
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(499, 612);
            this.Controls.Add(label5);
            this.Controls.Add(textBox4);
            this.Controls.Add(textBox3);
            this.Controls.Add(button2);
            this.Controls.Add(button1);
            this.Controls.Add(radioButton2);
            this.Controls.Add(radioButton1);
            this.Controls.Add(textBox2);
            this.Controls.Add(textBox1);
            this.Controls.Add(checkBox11);
            this.Controls.Add(checkBox10);
            this.Controls.Add(checkBox9);
            this.Controls.Add(checkBox8);
            this.Controls.Add(checkBox7);
            this.Controls.Add(checkBox6);
            this.Controls.Add(checkBox5);
            this.Controls.Add(checkBox1);
            this.Controls.Add(checkBox4);
            this.Controls.Add(checkBox3);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "Form1";
            this.Text = Version_info;

            var handle = GetConsoleWindow();

            ShowWindow(handle, SW_HIDE); //Hide Console Window
            //ShowWindow(handle, SW_SHOW); //Show Console Window
        }
        
        private void checkBox1_click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox4.Checked = true; checkBox5.Checked = true;
                checkBox6.Checked = true; checkBox7.Checked = true;
                checkBox8.Checked = true; checkBox9.Checked = true;
                checkBox10.Checked = true; checkBox11.Checked = true;
                textBox4.Text = "All Datacenter Selected.";
            }
            else
            {
                checkBox4.Checked = false; checkBox5.Checked = false;
                checkBox6.Checked = false; checkBox7.Checked = false;
                checkBox8.Checked = false; checkBox9.Checked = false;
                checkBox10.Checked = false; checkBox11.Checked = false;
                textBox4.Text = "All Datacenter Unselected.";
            }
        }
        private void button1_click(object sender, EventArgs e)
        {
            //First check if all criterias are met
            if
                (
                (radioButton1.Checked || radioButton2.Checked) &&
                (checkBox1.Checked || checkBox4.Checked ||
                checkBox5.Checked || checkBox6.Checked ||
                checkBox7.Checked || checkBox8.Checked ||
                checkBox9.Checked || checkBox10.Checked ||
                checkBox11.Checked) && textBox1.Text != ""
                )
            {Click_do(checkBox3.Checked);}
            else
            {textBox4.Text = @"Some parts are not checked!";}}

            int Click_do(bool asFile)
            {
                textBox4.Text = "Generating SQL...";

                if (radioButton1.Checked)
                {
                    //MA mode
                    Gen_sql_ma gensql1 = new Gen_sql_ma();
                    //MessageBox.Show(gensql1.Gen(Parse_DC_Gen(), textBox1.Text));
                    textBox2.Text = gensql1.Gen(Parse_DC_Gen(), textBox1.Text);
                }
                if (radioButton2.Checked)
                {
                    Gen_sql_shout gensql2 = new Gen_sql_shout();
                    textBox2.Text = gensql2.Gen(Parse_DC_Gen(), textBox1.Text);
                }
                if (asFile)
                {
                    string dir_out = Directory.GetCurrentDirectory();
                    dir_out += @"\" +
                        DateTime.Now.ToShortDateString().Replace("-", "_") + "_" +
                        DateTime.Now.ToShortTimeString().Replace(":", "");
                    dir_out = dir_out.Remove(dir_out.Length - 3, 3);
                    dir_out += "_" + textBox3.Text + ".sql";
                    //MessageBox.Show(dir_out);
                    File.WriteAllText(dir_out, textBox2.Text);
                    MessageBox.Show("File written to " + dir_out);
                }
                textBox4.Text = "Generating SQL...Done!";
                return 0;
            }
            string Parse_DC_Gen()
            {
                List<CheckBox> cbx_array = new List<CheckBox>();
                cbx_array.Add(checkBox4 as CheckBox); cbx_array.Add(checkBox5 as CheckBox);
                cbx_array.Add(checkBox6 as CheckBox); cbx_array.Add(checkBox7 as CheckBox);
                cbx_array.Add(checkBox8 as CheckBox); cbx_array.Add(checkBox9 as CheckBox);
                cbx_array.Add(checkBox10 as CheckBox); cbx_array.Add(checkBox11 as CheckBox);
                StringBuilder sb1 = new StringBuilder();
                foreach (CheckBox ctrl in cbx_array)
                {
                    if (ctrl.Checked)
                    {
                        sb1.Append(ctrl.Text + ",");
                    }
                }
                sb1.Remove(sb1.Length - 1, 1); //cut off last ","
                return sb1.ToString();
            }


        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = @"Parameter: " +
                "Input M/Agent Names, " +
                "i.e.: abc00101,abc00201," +
                "abc00301,bcd%,%dc%";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = @"Parameter: " +
                "Input Job Names, " +
                "i.e.: ABC00A,ABC01A," +
                "ABC03A,BCD%,%DC%,*ABC*,*CE*";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                label5.Enabled = true;
                label5.Visible = true;
                textBox3.Enabled = true;
                textBox3.Visible = true;
            }
            else
            {
                label5.Enabled = false;
                label5.Visible = false;
                textBox3.Enabled = false;
                textBox3.Visible = false;
            }
        }

        public class Gen_sql_ma
        {
            public string str_dc;
            public string str_param;
            private string sql1 = "SELECT j.memname, " +
                "t.data_center, j.node_id, j.application\r\n" +
                "  FROM def_job j, def_tables t\r\n" +
                " WHERE j.table_id = t.table_id\r\n" +
                " AND ";
            private string str_comb = @"t.Data_center = '{0}'";
            private string str_comb1 = @"j.node_id = '{0}'";
            private StringBuilder sb_sql2 = new StringBuilder();
            private StringBuilder sb_sql3 = new StringBuilder();

            public string Gen(string s_DC, string s_PARAM)
            {
                str_dc = s_DC;
                str_param = s_PARAM;
                //s_DC = 'dc1,dc2,dc3'
                string[] stra1 = str_dc.Split(',');
                sb_sql2.Append("( ");
                int ix = stra1.Count() - 1;
                for (int i = 0; i < ix; i++)
                {
                    if (stra1[i] != "")
                    {
                        sb_sql2.Append(string.Format(str_comb, stra1[i]) + "\r\n    OR ");
                    }
                }
                sb_sql2.Append(string.Format(str_comb, stra1[ix]) + ")");
                sb_sql2.Append("\r\n AND ");
                //s_PARAM 'abc10101%'
                string[] stra2 = str_param.Replace("*", "%").Split(',');
                sb_sql3.Append("( ");
                ix = stra2.Count() - 1;
                for (int i = 0; i < ix; i++)
                {
                    if (stra2[i] != "")
                    {
                        sb_sql3.Append(string.Format(str_comb1, stra2[i]) + "\r\n    OR ");
                    }
                }
                sb_sql3.Append(string.Format(str_comb1, stra2[ix]) + ")");
                sb_sql3.Append(";");

                string sql_out = sql1 + sb_sql2.ToString() + sb_sql3.ToString();
                return sql_out;
            }

        }
        public class Gen_sql_shout
        {
            public string str_dc;
            public string str_param;
            private string sql1 = "SELECT j.memname, " +
                "t.data_center, j.node_id,\r\n" +
                "s.when_cond, s.shout_time, s.urgency, s.destination\r\n" +
                "  FROM def_job j, def_tables t, def_ver_shout s\r\n" +
                " WHERE j.table_id = t.table_id AND j.table_id = s.table_id\r\n" +
                " AND j.job_id = s.job_id AND t.table_id = j.table_id\r\n" +
                " AND j.task_type != 'Dummy' AND s.is_current_version = 'Y'\r\n" +
                " AND ";
            private string str_comb = @"t.Data_center = '{0}'";
            private string str_comb1 = @"j.memname = '{0}'";
            private StringBuilder sb_sql2 = new StringBuilder();
            private StringBuilder sb_sql3 = new StringBuilder();

            public string Gen(string s_DC, string s_PARAM)
            {
                str_dc = s_DC;
                str_param = s_PARAM;
                //s_DC = 'dc1,dc2,dc3'
                string[] stra1 = str_dc.Split(',');
                sb_sql2.Append("( ");
                int ix = stra1.Count() - 1;
                for (int i = 0; i < ix; i++)
                {
                    if (stra1[i] != "")
                    {
                        sb_sql2.Append(string.Format(str_comb, stra1[i]) + "\r\n    OR ");
                    }
                }
                sb_sql2.Append(string.Format(str_comb, stra1[ix]) + ")");
                sb_sql2.Append("\r\n AND ");
                //s_PARAM 'JOB01A%', also, replace all '*' with %
                string[] stra2 = str_param.Replace("*", "%").Split(',');
                sb_sql3.Append("( ");
                ix = stra2.Count() - 1;
                for (int i = 0; i < ix; i++)
                {
                    if (stra2[i] != "")
                    {
                        sb_sql3.Append(string.Format(str_comb1, stra2[i]) + "\r\n    OR ");
                    }
                }
                sb_sql3.Append(string.Format(str_comb1, stra2[ix]) + ")");
                sb_sql3.Append(";");

                string sql_out = sql1 + sb_sql2.ToString() + sb_sql3.ToString();
                return sql_out;
            }
        }
    }
    


}