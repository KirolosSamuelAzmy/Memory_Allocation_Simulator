using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace MemoryAllocation
{
    public partial class Form1 : Form
    {


        /*List salah needs
        List<segment> ss     (dih ely hta5odha mn code mark...5liha ka parameter 3ndk fi 2lfn w aktb 2lba2i da fi awl 2lfn)

         List<string> segmentation_names = new List<string>();
         List<double> start_intervals = new List<double>();
         List<double> end_intervals = new List<double>();
            for (int i = 0; i<ss.Count; i++)
            {
                segmentation_names.Add(ss[i].name);
                start_intervals.Add(ss[i].start);
                end_intervals.Add(ss[i].start + ss[i].size);
            }
     */


        string process_name;
        bool initialization = true;
        bool isBest;

        Point startPoint = new Point(0, 0);
        bool dragging = false;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void label5_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


        void switch_reset()
        {
            switch_seg_table(true);
            holeList.Visible = initialization;
            tbHoleSize.Visible = initialization;
            tbHoleStart.Visible = initialization;
            addHole.Visible = initialization;
            rmvHole.Visible = initialization;
            initHoleLabel.Visible = initialization;
            holeStLabel.Visible = initialization;
            holeSizeLabel.Visible = initialization;
            tbMemSize.Visible = initialization;
            lblMemSize.Visible = initialization;
            mem.Visible = !initialization;
            beginSeg.Enabled = !initialization;
            tbNewProcess.Enabled = !initialization;
            if (initialization)
            {
                alBtn.Text = "Initialize Memory";
                List<double> dummy = new List<double>();
                dummy.Add(memSize);
                Add_Initial_Allocation(dummy, dummy);
            }

            else alBtn.Text = "Allocate Current Process";

        }

        void switch_seg_table(bool isTableVisible)
        {
            foreach (Control c in this.Controls)
            {
                if (c.Tag == null) continue;
                if (c.Tag.ToString() == "segListWhole")
                {
                    c.Visible = !isTableVisible;
                }
            }
            table.Visible = isTableVisible;
            tableLbl.Visible = isTableVisible;
        }

        Color nextColor()
        {
            Color c = colors[colorCounter];
            colorCounter++;
            if (colorCounter >= colors.Count())
            {
                colorCounter = 0;
            }
            return c;
        }

        void Add_Proccess(string p_name,List<segment> ss)
        {
            List<string> segmentation_names = new List<string>();
            List<double> start_intervals = new List<double>();
            List<double> end_intervals = new List<double>();
            for (int i = 0; i < ss.Count; i++)
            {
                segmentation_names.Add(ss[i].name);
                start_intervals.Add(ss[i].start);
                end_intervals.Add(ss[i].start + ss[i].size);
            }
            
            Color color = nextColor(); 
            List<int> process = new List<int>();
            for (int i = 0; i < ss.Count; i++) {
                int seg = mem.Series[0].Points.AddXY(0.1, start_intervals[i], end_intervals[i]);
                mem.Series[0].Points[seg].Label = p_name +": "+ segmentation_names[i];
                mem.Series[0].Points[seg].LabelForeColor = Color.WhiteSmoke;
                mem.Series[0].Points[seg].Color = color;
                mem.Series[0].Points[seg].BorderWidth = 1;
                mem.Series[0].Points[seg].BorderColor = Color.Black;

                CustomLabel label_start = new CustomLabel();
                label_start.ToPosition = 2 * start_intervals[i];
                label_start.Text = start_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_start);

                CustomLabel label_end = new CustomLabel();
                label_end.ToPosition = 2 * end_intervals[i];
                label_end.Text = end_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_end);
                process.Add(seg);
            }
            Processes[p_name] = process;
            ProcessesSegments[p_name] = segmentation_names;
            ProcessesIntervalStarts[p_name] = start_intervals;
            ProcessesIntervalEnds[p_name] = end_intervals;
            ProcessesColors[p_name] = color;
        }
        void Add_Proccess(string p_name, List<segment> ss,Color color)
        {
            List<string> segmentation_names = new List<string>();
            List<double> start_intervals = new List<double>();
            List<double> end_intervals = new List<double>();
            for (int i = 0; i < ss.Count; i++)
            {
                segmentation_names.Add(ss[i].name);
                start_intervals.Add(ss[i].start);
                end_intervals.Add(ss[i].start + ss[i].size);
            }
            
            List<int> process = new List<int>();
            for (int i = 0; i < ss.Count; i++)
            {
                int seg = mem.Series[0].Points.AddXY(0.1, start_intervals[i], end_intervals[i]);
                mem.Series[0].Points[seg].Label = p_name + ": " + segmentation_names[i];
                mem.Series[0].Points[seg].LabelForeColor = Color.WhiteSmoke;
                mem.Series[0].Points[seg].Color = color;
                mem.Series[0].Points[seg].BorderWidth = 1;
                mem.Series[0].Points[seg].BorderColor = Color.Black;

                CustomLabel label_start = new CustomLabel();
                label_start.ToPosition = 2 * start_intervals[i];
                label_start.Text = start_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_start);

                CustomLabel label_end = new CustomLabel();
                label_end.ToPosition = 2 * end_intervals[i];
                label_end.Text = end_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_end);
                process.Add(seg);
            }
            Processes[p_name] = process;
            ProcessesSegments[p_name] = segmentation_names;
            ProcessesIntervalStarts[p_name] = start_intervals;
            ProcessesIntervalEnds[p_name] = end_intervals;
            ProcessesColors[p_name] = color;
        }
        void Add_Proccess(string p_name, List<string> segmentation_names, List<double> start_intervals, List<double> end_intervals,Color color)
        {
            List<int> process = new List<int>();
            for (int i = 0; i < start_intervals.Count; i++)
            {
                int seg = mem.Series[0].Points.AddXY(0.1, start_intervals[i], end_intervals[i]);
                mem.Series[0].Points[seg].Label = p_name + ": " + segmentation_names[i];
                mem.Series[0].Points[seg].LabelForeColor = Color.WhiteSmoke;
                mem.Series[0].Points[seg].Color = color;
                mem.Series[0].Points[seg].BorderWidth = 1;
                mem.Series[0].Points[seg].BorderColor = Color.Black;

                CustomLabel label_start = new CustomLabel();
                label_start.ToPosition = 2 * start_intervals[i];
                label_start.Text = start_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_start);

                CustomLabel label_end = new CustomLabel();
                label_end.ToPosition = 2 * end_intervals[i];
                label_end.Text = end_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_end);

                process.Add(seg);

            }
            Processes[p_name] = process;
            ProcessesSegments[p_name] = segmentation_names;
            ProcessesIntervalStarts[p_name] = start_intervals;
            ProcessesIntervalEnds[p_name] = end_intervals;
            ProcessesColors[p_name] = color;
        }
        void Add_Initial_Allocation(List<double> start_intervals, List<double> end_intervals)
        {
            Color color = Color.DarkGray;
            List<double> process = new List<double>();
            for (int i = 0; i < start_intervals.Count; i++)
            {
                int seg = mem.Series[0].Points.AddXY(0.1, start_intervals[i], end_intervals[i]);
                mem.Series[0].Points[seg].Color = color;
                mem.Series[0].Points[seg].BorderWidth = 1;
                mem.Series[0].Points[seg].BorderColor = Color.Black;

                CustomLabel label_start = new CustomLabel();
                label_start.ToPosition = 2 * start_intervals[i];
                label_start.Text = start_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_start);

                CustomLabel label_end = new CustomLabel();
                label_end.ToPosition = 2 * end_intervals[i];
                label_end.Text = end_intervals[i].ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(label_end);
                

            }
        }

        void Remove_Process(string p_name)
        {
            cbPList.Items.Remove(p_name);
            for (int i = Processes[p_name].Count - 1; i >= 0; i--)
            {
                mem.Series[0].Points.RemoveAt(Processes[p_name][i]);
            }
            mem.Series[0].Points.Clear();

            List<double> dummy = new List<double>();
            dummy.Add(memSize);
            Add_Initial_Allocation(dummy, dummy);

            Processes.Remove(p_name);
            ProcessesSegments.Remove(p_name);
            ProcessesIntervalStarts.Remove(p_name);
            ProcessesIntervalEnds.Remove(p_name);
            ProcessesColors.Remove(p_name);
            mem.ChartAreas[0].AxisY.CustomLabels.Clear();

            for (int i = 0; i < Processes.Count; i++)
            {
                string process_name = Processes.ElementAt(i).Key;
                Add_Proccess(process_name, ProcessesSegments[process_name], ProcessesIntervalStarts[process_name], ProcessesIntervalEnds[process_name], ProcessesColors[process_name]);
            }
            CustomLabel zero_label = new CustomLabel();
            CustomLabel max_label = new CustomLabel();
            zero_label.ToPosition = 0.1;
            zero_label.Text = "0";
            max_label.ToPosition = 2 * memSize;
            max_label.Text = memSize.ToString();
            mem.ChartAreas[0].AxisY.CustomLabels.Add(zero_label);
            mem.ChartAreas[0].AxisY.CustomLabels.Add(max_label);
            if ((int)memSize > 5)
                mem.ChartAreas[0].AxisY.LabelAutoFitMinFontSize = (int)memSize;
        }
        Dictionary<string,List<int>> Processes = new Dictionary<string, List<int>>();
        Dictionary<string, List<string>> ProcessesSegments = new Dictionary<string, List<string>>();
        Dictionary<string, List<double>> ProcessesIntervalStarts = new Dictionary<string, List<double>>();
        Dictionary<string, List<double>> ProcessesIntervalEnds = new Dictionary<string, List<double>>();
        Dictionary<string, Color> ProcessesColors = new Dictionary<string, Color>();
        double memSize;
        int colorCounter = 0;
        List<Color> colors = new List<Color>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mem.ChartAreas[0].CursorY.Interval = 0;
            //Ordered Color Palette
            colors.Add(Color.DarkGreen);
            colors.Add(Color.DarkGoldenrod);
            colors.Add(Color.DarkRed);
            colors.Add(Color.Green);
            colors.Add(Color.Navy);
            colors.Add(Color.Olive);
            colors.Add(Color.DarkSalmon);
            colors.Add(Color.Honeydew);
            colors.Add(Color.LawnGreen);
            colors.Add(Color.DarkSlateBlue);
            colors.Add(Color.GreenYellow);

            mem.Series[0]["PointWidth"] = "2";
            
            switch_reset();

            foreach (Control c in this.Controls)
            {
                if (c.Tag == null) continue;
                if (c.Tag.ToString() == "segListWhole")
                {
                    c.Visible = !c.Visible;
                }
            }
            switch_seg_table(true);
        }


        private void mem_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePoint = new Point(e.X, e.Y);
            mem.ChartAreas[0].CursorY.SetCursorPixelPosition(mousePoint, true);
        }

        
        ToolTip toolTip = new ToolTip();
        private void mem_MouseDown(object sender, MouseEventArgs e)
        {
            toolTip.Hide(mem);
            toolTip.Show(mem.ChartAreas[0].CursorY.Position.ToString(), mem); 
        }

        private void beginSeg_Click(object sender, EventArgs e)
        {
            if (tbNewProcess.Text.Length > 0)
            {
                process_name = tbNewProcess.Text;
                p_name_label.Text = process_name;
                tbNewProcess.Enabled = false;
                beginSeg.Enabled = false;
                AddSeg.Enabled = true;
                RmvSeg.Enabled = true;
                tbSegName.Enabled = true;
                tbSegSize.Enabled = true;
                switch_seg_table(false);
            }
        }

        private void AddSeg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSegName.Text) || string.IsNullOrEmpty(tbSegSize.Text)) return;
            try
            {
                Exception ex = new Exception();
                if (double.Parse(tbSegSize.Text) <= 0) throw ex;

            }
            catch
            {
                MessageBox.Show("Invalid segment size!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ListViewItem item = new ListViewItem(tbSegName.Text);
            item.SubItems.Add(tbSegSize.Text);

            segList.Items.Add(item);
            tbSegName.Clear(); tbSegSize.Clear();
            tbSegName.Select();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RmvSeg_Click(object sender, EventArgs e)
        {
            if (segList.SelectedIndices.Count>0)
            {
                segList.Items.Remove(segList.SelectedItems[0]);
            }
        }
       
        private void addHole_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbHoleStart.Text) || string.IsNullOrEmpty(tbHoleSize.Text)) return;
            try
            {
                Exception ex = new Exception();
                if (double.Parse(tbHoleStart.Text) < 0 || double.Parse(tbHoleSize.Text)<= 0) throw ex;

            }
            catch
            {
                MessageBox.Show("Invalid hole parameter!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
              ListViewItem item = new ListViewItem(tbHoleStart.Text);
              item.SubItems.Add(tbHoleSize.Text);
             
              holeList.Items.Add(item);
              tbHoleStart.Clear(); tbHoleSize.Clear();
              tbHoleStart.Select();
        }

        private void rmvHole_Click(object sender, EventArgs e)
        {
            if (holeList.SelectedIndices.Count > 0)
            {
                holeList.Items.Remove(holeList.SelectedItems[0]);
            }
        }
        
        private void alBtn_Click(object sender, EventArgs e)
        {
            if (initialization)
            {

                if (tbMemSize.Text.Length <= 0) { MessageBox.Show("You haven't set the maximum memory size!", "Parameter unset!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);tbMemSize.Select(); return; }
                if (holeList.Items.Count <= 0) { MessageBox.Show("You must add holes or the whole memory will be initially allocated to one segment!", "Parameter unset!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return; }

                if (string.IsNullOrEmpty(tbMemSize.Text) || string.IsNullOrEmpty(tbMemSize.Text)) return;
                try
                {
                    Exception ex = new Exception();
                    if (double.Parse(tbMemSize.Text) <= 0 || double.Parse(tbMemSize.Text) <= 0) throw ex;

                }
                catch
                {
                    MessageBox.Show("Invalid Max memory parameter!", "Invalid input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                memSize = double.Parse(tbMemSize.Text);
                mem.ChartAreas[0].AxisX.Maximum = 1.01;
                mem.ChartAreas[0].AxisY.Maximum = memSize + 0.0001;
                mem.ChartAreas[0].AxisY.Interval = memSize;
                CustomLabel zero_label = new CustomLabel();
                CustomLabel max_label = new CustomLabel();
                zero_label.ToPosition = 0.1;
                zero_label.Text = "0";
                max_label.ToPosition = 2 * memSize;
                max_label.Text = memSize.ToString();
                mem.ChartAreas[0].AxisY.CustomLabels.Add(zero_label);
                mem.ChartAreas[0].AxisY.CustomLabels.Add(max_label);
                if ((int)memSize > 5)
                    mem.ChartAreas[0].AxisY.LabelAutoFitMinFontSize = (int)memSize;

                List<double> holeStartsList = new List<double>();
                List<double> holeSizesList = new List<double>();
                for (int i = 0; i < holeList.Items.Count; i++)
                {  
                        holeStartsList.Add(double.Parse(holeList.Items[i].SubItems[0].Text));
                        holeSizesList.Add(double.Parse(holeList.Items[i].SubItems[1].Text)); 
                }
                double total=0;
                for (int i = 0; i < holeSizesList.Count; i++) {
                    total += holeSizesList[i];
                    holeList.Items.Clear();
                    tbHoleSize.Clear();
                    tbHoleStart.Clear();
                }
                if (total>memSize) {
                    MessageBox.Show("Invalid holes input!, Out of memory! ", "ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return; }
                else {
                    initialization = false;
                    switch_reset();
                    add_holes(holeStartsList, holeSizesList);
                    fix_holes();
                    startingSegments(memSize, h_list);
                    for (int i = 0; i < temp_seg_list.Count; i++) {
                        List<segment> temp = new List<segment>();
                        temp.Add(temp_seg_list[i]);
                        List<string> segmentation_names = new List<string>();
                        List<double> start_intervals = new List<double>();
                        List<double> sizes = new List<double>();
                        for (int j = 0; j < temp.Count; j++)
                        {
                            segmentation_names.Add(temp[j].name);
                            start_intervals.Add(temp[j].start);
                            sizes.Add(temp[j].size);
                        }
                        TreeNode treeNode = new TreeNode("Initially allocated " + (i + 1).ToString());
                        treeNode.Name = "Initially allocated " + (i + 1).ToString();
                        cbPList.Items.Add("Initially allocated " + (i + 1).ToString());
                        table.Nodes.Add(treeNode);
                        table.Nodes["Initially allocated " + (i + 1).ToString()].Nodes.Add("Limit = " + sizes[0]);
                        table.Nodes["Initially allocated " + (i + 1).ToString()].Nodes.Add("Base = " + start_intervals[0]);
                        table.Nodes["Initially allocated " + (i + 1).ToString()].Nodes[0].NodeFont = Font;
                        table.Nodes["Initially allocated " + (i + 1).ToString()].Nodes[1].NodeFont = Font;
                        table.ExpandAll();
                        table.EndUpdate();
                        Add_Proccess("Initially allocated " + (i + 1).ToString(), temp,Color.DarkGray);
                        temp.Clear();
                    }

                    temp_seg_list.Clear();
                }
                //NOW YOU HAVE THE SIX INPUTS FROM THE GUI AS VARIABLES
                //process_name
                //memSize
                //segNamesList
                //segSizesList
                //holeStartsList
                //holeSizesList
                //method

                //TODO:
                //ON FIRST ALLOCATE ONLY: INSERT HOLE LISTS TO BACKEND AND CALL Add_Initial_Allocation() WITH THE INVERSE HOLE FUNCTION FROM THE BACKEND
            }
            else
            {

                if (segList.Items.Count == 0) return;
                
                tbNewProcess.Enabled = true;
                beginSeg.Enabled = true;
                RmvSeg.Enabled = false;
                AddSeg.Enabled = false;
                tbSegName.Enabled = false;
                tbSegSize.Enabled = false;

                List<string> segNamesList = new List<string>();
                List<double> segSizesList = new List<double>();

                for (int i = 0; i < segList.Items.Count; i++)
                {
                    segNamesList.Add(segList.Items[i].SubItems[0].Text);
                    segSizesList.Add(double.Parse(segList.Items[i].SubItems[1].Text));
                }

                
                isBest = rbBest.Checked;
                if (isBest)
                {
                    add_segments(segSizesList, segNamesList);
                    best_fit(process_name);
                    if (warning) {
                        p_name_label.Text = " ";
                        segList.Items.Clear();
                        tbNewProcess.Clear();
                        return;
                    }
                    else {
                        cbPList.Items.Add(process_name);
                        table.BeginUpdate();
                        TreeNode treeNode = new TreeNode(process_name);
                        treeNode.Name = process_name;
                        table.Nodes.Add(treeNode);
                        for (int i = 0; i < segSizesList.Count; ++i)
                        {
                            TreeNode treeNode2 = new TreeNode(segNamesList[i]);
                            treeNode2.Name = segNamesList[i];
                            //table.Nodes.Add(treeNode2);
                            table.Nodes[process_name].Nodes.Add(treeNode2);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes.Add("Limit = " + temp_seg_list[i].size);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes.Add("Base = " + temp_seg_list[i].start);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes[0].NodeFont = Font;
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes[1].NodeFont = Font;
                        }
                        table.ExpandAll();
                        table.EndUpdate();
                        Add_Proccess(process_name, temp_seg_list);
                        switch_seg_table(true);
                        temp_seg_list.Clear();
                    }
                }
                else if (!isBest) {
                    add_segments(segSizesList, segNamesList);
                    first_fit(process_name);
                    if (warning) {
                        p_name_label.Text = " ";
                        segList.Items.Clear();
                        tbNewProcess.Clear();
                        return;
                    }
                    else
                    {
                        cbPList.Items.Add(process_name);
                        table.BeginUpdate();
                        TreeNode treeNode = new TreeNode(process_name);
                        treeNode.Name = process_name;
                        table.Nodes.Add(treeNode);
                        for (int i = 0; i < segSizesList.Count; ++i)
                        {
                            TreeNode treeNode2 = new TreeNode(segNamesList[i]);
                            treeNode2.Name = segNamesList[i];
                            table.Nodes[process_name].Nodes.Add(treeNode2);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes.Add("Limit = " + temp_seg_list[i].size);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes.Add("Base = " + temp_seg_list[i].start);
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes[0].NodeFont = Font;
                            table.Nodes[process_name].Nodes[segNamesList[i]].Nodes[1].NodeFont = Font;
                        }
                        table.ExpandAll();
                        table.EndUpdate();
                        Add_Proccess(process_name, temp_seg_list);
                        switch_seg_table(true);
                        temp_seg_list.Clear();
                    }
                }

                //NOW YOU HAVE THE SIX INPUTS FROM THE GUI AS VARIABLES
                //process_name
                //memSize
                //segNamesList
                //segSizesList
                //holeStartsList
                //holeSizesList
                //method

                //TODO:
                //INSERT SEG LISTS TO BACKEND AND CALL Add_Process() HERE WITH THE BACKEND OUTPUT


                segList.Items.Clear();
                tbNewProcess.Text = "";
                p_name_label.Text = "";
                process_name = ""; 
            }

        }

        private void deBtn_Click(object sender, EventArgs e)
        {
            if (cbPList.SelectedIndex > 0)
            {
                string name = cbPList.SelectedItem.ToString();
                deallocate(name);
                generate_holes();
                Remove_Process(name);
                table.Nodes.RemoveByKey(name);
            }
            //TODO:
            //INFORM THE BACKEND THAT A PROCESS HAS BEEN REMOVED AND A NEW HOLE IS AVAILABLE
        }

        private void rstBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to reset?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            int count = cbPList.Items.Count;
            for (int i = count-1; i > 0; i--)
            {
                string name = cbPList.Items[i].ToString();
                Remove_Process(name);
            }
            table.Nodes.Clear();
            initialization = true;
            switch_reset();
            mem.ChartAreas[0].AxisY.CustomLabels.Clear();
            mem.Series[0].Points.Clear();
            Processes.Clear();
            ProcessesIntervalEnds.Clear();
            ProcessesIntervalStarts.Clear();
            ProcessesSegments.Clear();
            segList.Items.Clear();
            holeList.Items.Clear();
            tbHoleSize.Clear();
            tbHoleStart.Clear();
            string cbPList_Init_Text = cbPList.Items[0].ToString(); 
            cbPList.Items.Clear();
            cbPList.Items.Add(cbPList_Init_Text);
            tbMemSize.Clear();
            tbNewProcess.Clear();
            tbSegName.Clear();
            tbSegSize.Clear();
            p_name_label.Text =" ";
            all_reset();
            //TODO:
            //RESET ALL BACKEND VARIABLES AS IF WE ARE STARTING OVER
        }
        void startingSegments(double memory_size, List<hole> holes)
        {
            double start, range;
            double current = 0;
            for (int i = 0; i < holes.Count(); i++)
            {
                start = holes[i].start;
                range = holes[i].size;
                if (current < start)
                {
                    segment s = new segment(start - current, "0", "Segment");
                    s.start = current;
                    seg_list.Add(s);
                    temp_seg_list.Add(s);
                    current = start + range;
                }
                else
                {
                    current = start + range;
                }
            }
            if (current < memory_size)
            {
                segment s = new segment(memory_size - current, "0", "Segment");
                s.start = current;
                seg_list.Add(s);
                temp_seg_list.Add(s);
            }
            for (int i = 0; i < temp_seg_list.Count; i++)
            {
                process p0 = new process(process_counter.ToString(), "Initially allocated " + (i + 1));
                temp_seg_list[i].code = process_counter.ToString();
                p_list.Add(p0);
                process_counter++;
            }

        }
        void add_segments(List<double> size, List<string> name)
        {
            for (int i = 0; i < size.Count; i++)
            {
                segment s = new segment(size[i], process_counter.ToString(), name[i]);
                temp_seg_list.Add(s);
            }
        }
        void add_holes(List<double> start, List<double> size)
        {
            for (int i = 0; i < start.Count; i++)
            {
                hole h = new hole(start[i], size[i]);
                h_list.Add(h);
            }
        }
        void first_fit(string process_name)
        {
            warning = false;
            bool flag = true;
            process p1 = new process(process_counter.ToString(), process_name);
            for (int i = 0; i < temp_seg_list.Count; i++)
            {
                p1.process_segments.Add(temp_seg_list[i]);
            }
            process_counter++;
            for (int j = 0; j < temp_seg_list.Count; j++)
            {
                for (int i = 0; i < h_list.Count; i++)
                {
                    if (temp_seg_list[j].size <= h_list[i].size)
                    {
                        flag = false;
                        temp_seg_list[j].start = h_list[i].start;
                        h_list[i].start = h_list[i].start + temp_seg_list[j].size;
                        h_list[i].size -= temp_seg_list[j].size;
                        break;
                    }
                }
                if (flag == true)
                {
                    warning = true;
                    MessageBox.Show("Not enough space for input process!", "ERROR!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    switch_seg_table(true);
                    temp_seg_list.Clear();
                    return;
                }
                  flag = true;
            }
            for (int i = 0; i < temp_seg_list.Count; i++)
            {
                seg_list.Add(temp_seg_list[i]);
            }
            p_list.Add(p1);
            //temp_seg_list.Clear();
        }

        void best_fit(string process_name)
        {
            warning = false;
            process p1 = new process(process_counter.ToString(), process_name);
            for (int i = 0; i < temp_seg_list.Count; i++)
            {
                p1.process_segments.Add(temp_seg_list[i]);
            }
            process_counter++;

            double min_size = -1;
            int min_index = -1;
            for (int j = 0; j < temp_seg_list.Count; j++)
            {
                min_size = -1;
                min_index = -1;
                for (int i = 0; i < h_list.Count; i++)
                {
                    if (temp_seg_list[j].size <= h_list[i].size)
                    {
                        if (min_size == -1 || min_size > h_list[i].size)
                        {
                            min_size = h_list[i].size;
                            min_index = i;
                        }
                    }
                }
                if (min_size == -1)
                {
                    warning = true;
                    MessageBox.Show("Not enough space for input process!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    switch_seg_table(true);
                    temp_seg_list.Clear();
                    return;
                }
                temp_seg_list[j].start = h_list[min_index].start;
                h_list[min_index].start = h_list[min_index].start + temp_seg_list[j].size;
                h_list[min_index].size -= temp_seg_list[j].size;
                if (h_list[min_index].size == 0)
                {
                    h_list.RemoveAt(min_index);
                }
            }
            for (int i = 0; i < temp_seg_list.Count; i++)
            {
                seg_list.Add(temp_seg_list[i]);
            }
            p_list.Add(p1);
            //temp_seg_list.Clear();
        }
        void generate_holes()
        {
            double current = 0;

            if (seg_list.Count == 0)
            {
                h_list.Clear();
                hole h = new hole(current, memSize);
                h_list.Add(h);
            }
            else
            {
                seg_list.Sort((x, y) => x.start.CompareTo(y.start));
                h_list.Clear();
                for (int i = 0; i < seg_list.Count; i++)
                {
                    if (current < seg_list[i].start)
                    {
                        hole h = new hole(current, seg_list[i].start - current);
                        h_list.Add(h);
                        current = seg_list[i].start + seg_list[i].size;
                    }
                    else
                    {
                        current += seg_list[i].size;
                    }
                }
                if (current < memSize)
                {
                    hole h = new hole(current, memSize - current);
                    h_list.Add(h);
                    current = memSize;
                }
            }
        }
        void deallocate(string name)
        {
            string code = "-1";
            for (int i = 0; i < p_list.Count; i++)
            {
                if (p_list[i].name == name)
                {
                    code = p_list[i].code;
                }
            }
            for (int i = 0; i < seg_list.Count; i++)
            {
                if (seg_list[i].code == code)
                {
                    seg_list.RemoveAt(i);
                    i--;
                }
            }
        }
        void all_reset() {
            h_list.Clear();
            temp_seg_list.Clear();
            seg_list.Clear();
            p_list.Clear();
                 
        }
        void fix_holes()
        {
            for (int i = 0; i < h_list.Count - 1; i++)
            {
                if (h_list[i].start + h_list[i].size == h_list[i + 1].start)
                {
                    hole h = new hole(h_list[i].start, h_list[i + 1].size + h_list[i].size);
                    h_list.RemoveAt(i);
                    h_list.RemoveAt(i);
                    h_list.Insert(i, h);
                }
            }
        }
        int process_counter = 1;
        bool warning = false;
        List<double> hole_start = new List<double>();
        List<double> hole_end = new List<double>();
        List<double> output_seg_start = new List<double>();
        List<double> output_seg_end = new List<double>();
        List<string> output_seg_names = new List<string>();
        List<hole> h_list = new List<hole>();
        List<process> p_list = new List<process>();
        List<segment> seg_list = new List<segment>();
        List<segment> temp_seg_list = new List<segment>();

        private void tbHoleSize_Enter(object sender, EventArgs e)
        {
            AcceptButton = addHole;
        }

        private void tbHoleStart_Enter(object sender, EventArgs e)
        {
            AcceptButton = addHole;
        }

        private void tbNewProcess_Enter(object sender, EventArgs e)
        {
            AcceptButton = beginSeg;
        }

        private void tbSegName_Enter(object sender, EventArgs e)
        {
            AcceptButton = AddSeg;
        }

        private void tbSegSize_Enter(object sender, EventArgs e)
        {
            AcceptButton = AddSeg;
        }

        private void tbMemSize_Enter(object sender, EventArgs e)
        {
            AcceptButton = alBtn;
        }
    }
    class hole
    {
        public double start, size;
        public hole(double st, double sz) { start = st; size = sz; }
        public void newHole(List<hole> hole_list, double st, double sz)
        {
            hole h = new hole(st, sz);
            hole_list.Add(h);
        }
    }
    class process
    {
        public string code, name;
        public List<segment> process_segments;
        public process(string s, string n)
        {
            process_segments = new List<segment>();
            code = s;
            name = n;
        }
    }
    class segment
    {
        public double start, size;
        public string code, name;
        public segment(double sz, string cd, string sn) { size = sz; code = cd; name = sn; }
    }
}
