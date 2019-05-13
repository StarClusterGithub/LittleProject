namespace IDNumberGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpCompletion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.btnCompletion = new System.Windows.Forms.Button();
            this.rtbCompletionResult = new System.Windows.Forms.RichTextBox();
            this.tpGenerate = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.tcFunction = new System.Windows.Forms.TabControl();
            this.tpCompletion.SuspendLayout();
            this.tpGenerate.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.tcFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpCompletion
            // 
            this.tpCompletion.Controls.Add(this.rtbCompletionResult);
            this.tpCompletion.Controls.Add(this.tbIDNumber);
            this.tpCompletion.Controls.Add(this.btnCompletion);
            this.tpCompletion.Controls.Add(this.label4);
            this.tpCompletion.Location = new System.Drawing.Point(4, 22);
            this.tpCompletion.Name = "tpCompletion";
            this.tpCompletion.Padding = new System.Windows.Forms.Padding(3);
            this.tpCompletion.Size = new System.Drawing.Size(464, 423);
            this.tpCompletion.TabIndex = 1;
            this.tpCompletion.Text = "Completion";
            this.tpCompletion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "IDNumber:";
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIDNumber.Location = new System.Drawing.Point(104, 31);
            this.tbIDNumber.MaxLength = 18;
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(309, 21);
            this.tbIDNumber.TabIndex = 1;
            // 
            // btnCompletion
            // 
            this.btnCompletion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompletion.Location = new System.Drawing.Point(178, 78);
            this.btnCompletion.Name = "btnCompletion";
            this.btnCompletion.Size = new System.Drawing.Size(75, 23);
            this.btnCompletion.TabIndex = 2;
            this.btnCompletion.Text = "Completion";
            this.btnCompletion.UseVisualStyleBackColor = true;
            // 
            // rtbCompletionResult
            // 
            this.rtbCompletionResult.Location = new System.Drawing.Point(41, 124);
            this.rtbCompletionResult.Name = "rtbCompletionResult";
            this.rtbCompletionResult.ReadOnly = true;
            this.rtbCompletionResult.Size = new System.Drawing.Size(372, 266);
            this.rtbCompletionResult.TabIndex = 3;
            this.rtbCompletionResult.Text = "在输入框内输入待补全的身份证号码,\n缺失的号码以下划线_代替,缺失号码不能超过1位.\n";
            // 
            // tpGenerate
            // 
            this.tpGenerate.Controls.Add(this.rtbDisplay);
            this.tpGenerate.Controls.Add(this.btnGenerate);
            this.tpGenerate.Controls.Add(this.cbDay);
            this.tpGenerate.Controls.Add(this.cbMonth);
            this.tpGenerate.Controls.Add(this.cbYear);
            this.tpGenerate.Controls.Add(this.label3);
            this.tpGenerate.Controls.Add(this.cbCity);
            this.tpGenerate.Controls.Add(this.label2);
            this.tpGenerate.Controls.Add(this.gbGender);
            this.tpGenerate.Controls.Add(this.cbProvince);
            this.tpGenerate.Controls.Add(this.label1);
            this.tpGenerate.Location = new System.Drawing.Point(4, 22);
            this.tpGenerate.Name = "tpGenerate";
            this.tpGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.tpGenerate.Size = new System.Drawing.Size(464, 423);
            this.tpGenerate.TabIndex = 0;
            this.tpGenerate.Text = "Generate";
            this.tpGenerate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Province:";
            // 
            // cbProvince
            // 
            this.cbProvince.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(125, 48);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(271, 20);
            this.cbProvince.TabIndex = 1;
            // 
            // gbGender
            // 
            this.gbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGender.Controls.Add(this.rbRandom);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Location = new System.Drawing.Point(62, 129);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(334, 84);
            this.gbGender.TabIndex = 2;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(146, 40);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 16);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(40, 40);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(47, 16);
            this.rbMale.TabIndex = 1;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbRandom
            // 
            this.rbRandom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(237, 40);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(59, 16);
            this.rbRandom.TabIndex = 2;
            this.rbRandom.Text = "Random";
            this.rbRandom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "City    :";
            // 
            // cbCity
            // 
            this.cbCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(125, 84);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(271, 20);
            this.cbCity.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date of birth:";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "随机",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100"});
            this.cbYear.Location = new System.Drawing.Point(156, 237);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(76, 20);
            this.cbYear.TabIndex = 6;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Items.AddRange(new object[] {
            "随机",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMonth.Location = new System.Drawing.Point(238, 237);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(76, 20);
            this.cbMonth.TabIndex = 7;
            // 
            // cbDay
            // 
            this.cbDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Items.AddRange(new object[] {
            "随机"});
            this.cbDay.Location = new System.Drawing.Point(320, 237);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(76, 20);
            this.cbDay.TabIndex = 8;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(192, 275);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.Location = new System.Drawing.Point(62, 304);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(334, 98);
            this.rtbDisplay.TabIndex = 10;
            this.rtbDisplay.Text = "";
            // 
            // tcFunction
            // 
            this.tcFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcFunction.Controls.Add(this.tpGenerate);
            this.tcFunction.Controls.Add(this.tpCompletion);
            this.tcFunction.Location = new System.Drawing.Point(12, 12);
            this.tcFunction.Name = "tcFunction";
            this.tcFunction.SelectedIndex = 0;
            this.tcFunction.Size = new System.Drawing.Size(472, 449);
            this.tcFunction.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.tcFunction);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDNumberGenerator by kuranadomoe";
            this.tpCompletion.ResumeLayout(false);
            this.tpCompletion.PerformLayout();
            this.tpGenerate.ResumeLayout(false);
            this.tpGenerate.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.tcFunction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpCompletion;
        private System.Windows.Forms.RichTextBox rtbCompletionResult;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Button btnCompletion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tpGenerate;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcFunction;
    }
}

