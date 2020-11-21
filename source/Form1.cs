using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Nokia_Repartition_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo Resizing system and vendor partitions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot flash partition bin//FIH_SDM660_AVB1_gpt_both0_3.5s_1v.bin ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p2.WaitForExit();
			
            Process pa = new Process();
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.RedirectStandardOutput = true;
            pa.StartInfo.FileName = "cmd.exe";
            pa.StartInfo.Arguments = "/c timeout 20 ";
            pa.StartInfo.CreateNoWindow = true;
            pa.Start();
            richTextBox1.Refresh();
            pa.WaitForExit();			

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c echo Rebooting to bootloader..";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            richTextBox1.Text = richTextBox1.Text + p.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c fastboot reboot-bootloader ";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p3.WaitForExit();

            Process pb = new Process();
            pb.StartInfo.UseShellExecute = false;
            pb.StartInfo.RedirectStandardOutput = true;
            pb.StartInfo.FileName = "cmd.exe";
            pb.StartInfo.Arguments = "/c timeout 20 ";
            pb.StartInfo.CreateNoWindow = true;
            pb.Start();
            richTextBox1.Refresh();
            pb.WaitForExit();

            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c echo formatting system_a..";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c fastboot format:ext4 system_a ";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Refresh();

            Process pc = new Process();
            pc.StartInfo.UseShellExecute = false;
            pc.StartInfo.RedirectStandardOutput = true;
            pc.StartInfo.FileName = "cmd.exe";
            pc.StartInfo.Arguments = "/c timeout 20 ";
            pc.StartInfo.CreateNoWindow = true;
            pc.Start();
            richTextBox1.Refresh();
            pc.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c echo formatting system_b..  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c fastboot format:ext4 system_b ";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Refresh();

            Process pd = new Process();
            pd.StartInfo.UseShellExecute = false;
            pd.StartInfo.RedirectStandardOutput = true;
            pd.StartInfo.FileName = "cmd.exe";
            pd.StartInfo.Arguments = "/c timeout 20 ";
            pd.StartInfo.CreateNoWindow = true;
            pd.Start();
            richTextBox1.Refresh();
            pd.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c echo formatting vendor_a.. ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c fastboot format:ext4 vendor_a ";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Refresh();

            Process pe = new Process();
            pe.StartInfo.UseShellExecute = false;
            pe.StartInfo.RedirectStandardOutput = true;
            pe.StartInfo.FileName = "cmd.exe";
            pe.StartInfo.Arguments = "/c timeout 20 ";
            pe.StartInfo.CreateNoWindow = true;
            pe.Start();
            richTextBox1.Refresh();
            pe.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c echo formatting vendor_b.. ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c fastboot format:ext4 vendor_b  ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Refresh();

            Process pf = new Process();
            pf.StartInfo.UseShellExecute = false;
            pf.StartInfo.RedirectStandardOutput = true;
            pf.StartInfo.FileName = "cmd.exe";
            pf.StartInfo.Arguments = "/c timeout 20 ";
            pf.StartInfo.CreateNoWindow = true;
            pf.Start();
            richTextBox1.Refresh();
            pf.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c echo Erasing userdata and rebooting bootloader.. ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c fastboot -w reboot-bootloader ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Refresh();

            Process pg = new Process();
            pg.StartInfo.UseShellExecute = false;
            pg.StartInfo.RedirectStandardOutput = true;
            pg.StartInfo.FileName = "cmd.exe";
            pg.StartInfo.Arguments = "/c timeout 20 ";
            pg.StartInfo.CreateNoWindow = true;
            pg.Start();
            richTextBox1.Refresh();
            pg.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c echo Rebooting to twrp-3.4.. ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c fastboot flash boot bin//twrp-3.4.0-0-DRG_sprout-11.0-20200909.img && fastboot reboot ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p15.WaitForExit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo Resizing system and vendor partitions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot flash partition bin//FIH_SDM660_AVB1_gpt_both0_4s_1v.bin ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p2.WaitForExit();
			
            Process pa = new Process();
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.RedirectStandardOutput = true;
            pa.StartInfo.FileName = "cmd.exe";
            pa.StartInfo.Arguments = "/c timeout 20 ";
            pa.StartInfo.CreateNoWindow = true;
            pa.Start();
            richTextBox1.Refresh();
            pa.WaitForExit();			

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c echo Rebooting to bootloader..";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            richTextBox1.Text = richTextBox1.Text + p.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c fastboot reboot-bootloader ";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p3.WaitForExit();

            Process pb = new Process();
            pb.StartInfo.UseShellExecute = false;
            pb.StartInfo.RedirectStandardOutput = true;
            pb.StartInfo.FileName = "cmd.exe";
            pb.StartInfo.Arguments = "/c timeout 20 ";
            pb.StartInfo.CreateNoWindow = true;
            pb.Start();
            richTextBox1.Refresh();
            pb.WaitForExit();

            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c echo formatting system_a..";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c fastboot format:ext4 system_a ";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Refresh();

            Process pc = new Process();
            pc.StartInfo.UseShellExecute = false;
            pc.StartInfo.RedirectStandardOutput = true;
            pc.StartInfo.FileName = "cmd.exe";
            pc.StartInfo.Arguments = "/c timeout 20 ";
            pc.StartInfo.CreateNoWindow = true;
            pc.Start();
            richTextBox1.Refresh();
            pc.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c echo formatting system_b..  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c fastboot format:ext4 system_b ";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Refresh();

            Process pd = new Process();
            pd.StartInfo.UseShellExecute = false;
            pd.StartInfo.RedirectStandardOutput = true;
            pd.StartInfo.FileName = "cmd.exe";
            pd.StartInfo.Arguments = "/c timeout 20 ";
            pd.StartInfo.CreateNoWindow = true;
            pd.Start();
            richTextBox1.Refresh();
            pd.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c echo formatting vendor_a.. ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c fastboot format:ext4 vendor_a ";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Refresh();

            Process pe = new Process();
            pe.StartInfo.UseShellExecute = false;
            pe.StartInfo.RedirectStandardOutput = true;
            pe.StartInfo.FileName = "cmd.exe";
            pe.StartInfo.Arguments = "/c timeout 20 ";
            pe.StartInfo.CreateNoWindow = true;
            pe.Start();
            richTextBox1.Refresh();
            pe.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c echo formatting vendor_b.. ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c fastboot format:ext4 vendor_b  ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Refresh();

            Process pf = new Process();
            pf.StartInfo.UseShellExecute = false;
            pf.StartInfo.RedirectStandardOutput = true;
            pf.StartInfo.FileName = "cmd.exe";
            pf.StartInfo.Arguments = "/c timeout 20 ";
            pf.StartInfo.CreateNoWindow = true;
            pf.Start();
            richTextBox1.Refresh();
            pf.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c echo Erasing userdata and rebooting bootloader.. ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c fastboot -w reboot-bootloader ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Refresh();

            Process pg = new Process();
            pg.StartInfo.UseShellExecute = false;
            pg.StartInfo.RedirectStandardOutput = true;
            pg.StartInfo.FileName = "cmd.exe";
            pg.StartInfo.Arguments = "/c timeout 20 ";
            pg.StartInfo.CreateNoWindow = true;
            pg.Start();
            richTextBox1.Refresh();
            pg.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c echo Rebooting to twrp-3.4.. ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c fastboot flash boot bin//twrp-3.4.0-0-DRG_sprout-11.0-20200909.img && fastboot reboot ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p15.WaitForExit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process p1 = new Process();
            p1.StartInfo.UseShellExecute = false;
            p1.StartInfo.RedirectStandardOutput = true;
            p1.StartInfo.FileName = "cmd.exe";
            p1.StartInfo.Arguments = "/c echo Resizing system and vendor partitions..";
            p1.StartInfo.CreateNoWindow = true;
            p1.Start();
            richTextBox1.Text = richTextBox1.Text + p1.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p1.WaitForExit();


            Process p2 = new Process();
            p2.StartInfo.UseShellExecute = false;
            p2.StartInfo.RedirectStandardOutput = true;
            p2.StartInfo.FileName = "cmd.exe";
            p2.StartInfo.Arguments = "/c fastboot flash partition bin//FIH_SDM660_AVB1_gpt_both0_4.5s_1v.bin ";
            p2.StartInfo.CreateNoWindow = true;
            p2.Start();
            richTextBox1.Text = richTextBox1.Text + p2.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p2.WaitForExit();
			
            Process pa = new Process();
            pa.StartInfo.UseShellExecute = false;
            pa.StartInfo.RedirectStandardOutput = true;
            pa.StartInfo.FileName = "cmd.exe";
            pa.StartInfo.Arguments = "/c timeout 20 ";
            pa.StartInfo.CreateNoWindow = true;
            pa.Start();
            richTextBox1.Refresh();
            pa.WaitForExit();			

            Process p = new Process();
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = "/c echo Rebooting to bootloader..";
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            richTextBox1.Text = richTextBox1.Text + p.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p.WaitForExit();

            Process p3 = new Process();
            p3.StartInfo.UseShellExecute = false;
            p3.StartInfo.RedirectStandardOutput = true;
            p3.StartInfo.FileName = "cmd.exe";
            p3.StartInfo.Arguments = "/c fastboot reboot-bootloader ";
            p3.StartInfo.CreateNoWindow = true;
            p3.Start();
            richTextBox1.Text = richTextBox1.Text + p3.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p3.WaitForExit();

            Process pb = new Process();
            pb.StartInfo.UseShellExecute = false;
            pb.StartInfo.RedirectStandardOutput = true;
            pb.StartInfo.FileName = "cmd.exe";
            pb.StartInfo.Arguments = "/c timeout 20 ";
            pb.StartInfo.CreateNoWindow = true;
            pb.Start();
            richTextBox1.Refresh();
            pb.WaitForExit();

            Process p4 = new Process();
            p4.StartInfo.UseShellExecute = false;
            p4.StartInfo.RedirectStandardOutput = true;
            p4.StartInfo.FileName = "cmd.exe";
            p4.StartInfo.Arguments = "/c echo formatting system_a..";
            p4.StartInfo.CreateNoWindow = true;
            p4.Start();
            richTextBox1.Text = richTextBox1.Text + p4.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p4.WaitForExit();

            Process p5 = new Process();
            p5.StartInfo.UseShellExecute = false;
            p5.StartInfo.RedirectStandardOutput = true;
            p5.StartInfo.FileName = "cmd.exe";
            p5.StartInfo.Arguments = "/c fastboot format:ext4 system_a ";
            p5.StartInfo.CreateNoWindow = true;
            p5.Start();
            richTextBox1.Refresh();

            Process pc = new Process();
            pc.StartInfo.UseShellExecute = false;
            pc.StartInfo.RedirectStandardOutput = true;
            pc.StartInfo.FileName = "cmd.exe";
            pc.StartInfo.Arguments = "/c timeout 20 ";
            pc.StartInfo.CreateNoWindow = true;
            pc.Start();
            richTextBox1.Refresh();
            pc.WaitForExit();


            Process p6 = new Process();
            p6.StartInfo.UseShellExecute = false;
            p6.StartInfo.RedirectStandardOutput = true;
            p6.StartInfo.FileName = "cmd.exe";
            p6.StartInfo.Arguments = "/c echo formatting system_b..  ";
            p6.StartInfo.CreateNoWindow = true;
            p6.Start();
            richTextBox1.Text = richTextBox1.Text + p6.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p6.WaitForExit();

            Process p7 = new Process();
            p7.StartInfo.UseShellExecute = false;
            p7.StartInfo.RedirectStandardOutput = true;
            p7.StartInfo.FileName = "cmd.exe";
            p7.StartInfo.Arguments = "/c fastboot format:ext4 system_b ";
            p7.StartInfo.CreateNoWindow = true;
            p7.Start();
            richTextBox1.Refresh();

            Process pd = new Process();
            pd.StartInfo.UseShellExecute = false;
            pd.StartInfo.RedirectStandardOutput = true;
            pd.StartInfo.FileName = "cmd.exe";
            pd.StartInfo.Arguments = "/c timeout 20 ";
            pd.StartInfo.CreateNoWindow = true;
            pd.Start();
            richTextBox1.Refresh();
            pd.WaitForExit();

            Process p8 = new Process();
            p8.StartInfo.UseShellExecute = false;
            p8.StartInfo.RedirectStandardOutput = true;
            p8.StartInfo.FileName = "cmd.exe";
            p8.StartInfo.Arguments = "/c echo formatting vendor_a.. ";
            p8.StartInfo.CreateNoWindow = true;
            p8.Start();
            richTextBox1.Text = richTextBox1.Text + p8.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p8.WaitForExit();

            Process p9 = new Process();
            p9.StartInfo.UseShellExecute = false;
            p9.StartInfo.RedirectStandardOutput = true;
            p9.StartInfo.FileName = "cmd.exe";
            p9.StartInfo.Arguments = "/c fastboot format:ext4 vendor_a ";
            p9.StartInfo.CreateNoWindow = true;
            p9.Start();
            richTextBox1.Refresh();

            Process pe = new Process();
            pe.StartInfo.UseShellExecute = false;
            pe.StartInfo.RedirectStandardOutput = true;
            pe.StartInfo.FileName = "cmd.exe";
            pe.StartInfo.Arguments = "/c timeout 20 ";
            pe.StartInfo.CreateNoWindow = true;
            pe.Start();
            richTextBox1.Refresh();
            pe.WaitForExit();

            Process p10 = new Process();
            p10.StartInfo.UseShellExecute = false;
            p10.StartInfo.RedirectStandardOutput = true;
            p10.StartInfo.FileName = "cmd.exe";
            p10.StartInfo.Arguments = "/c echo formatting vendor_b.. ";
            p10.StartInfo.CreateNoWindow = true;
            p10.Start();
            richTextBox1.Text = richTextBox1.Text + p10.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p10.WaitForExit();

            Process p11 = new Process();
            p11.StartInfo.UseShellExecute = false;
            p11.StartInfo.RedirectStandardOutput = true;
            p11.StartInfo.FileName = "cmd.exe";
            p11.StartInfo.Arguments = "/c fastboot format:ext4 vendor_b  ";
            p11.StartInfo.CreateNoWindow = true;
            p11.Start();
            richTextBox1.Refresh();

            Process pf = new Process();
            pf.StartInfo.UseShellExecute = false;
            pf.StartInfo.RedirectStandardOutput = true;
            pf.StartInfo.FileName = "cmd.exe";
            pf.StartInfo.Arguments = "/c timeout 20 ";
            pf.StartInfo.CreateNoWindow = true;
            pf.Start();
            richTextBox1.Refresh();
            pf.WaitForExit();

            Process p12 = new Process();
            p12.StartInfo.UseShellExecute = false;
            p12.StartInfo.RedirectStandardOutput = true;
            p12.StartInfo.FileName = "cmd.exe";
            p12.StartInfo.Arguments = "/c echo Erasing userdata and rebooting bootloader.. ";
            p12.StartInfo.CreateNoWindow = true;
            p12.Start();
            richTextBox1.Text = richTextBox1.Text + p12.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p12.WaitForExit();

            Process p13 = new Process();
            p13.StartInfo.UseShellExecute = false;
            p13.StartInfo.RedirectStandardOutput = true;
            p13.StartInfo.FileName = "cmd.exe";
            p13.StartInfo.Arguments = "/c fastboot -w reboot-bootloader ";
            p13.StartInfo.CreateNoWindow = true;
            p13.Start();
            richTextBox1.Refresh();

            Process pg = new Process();
            pg.StartInfo.UseShellExecute = false;
            pg.StartInfo.RedirectStandardOutput = true;
            pg.StartInfo.FileName = "cmd.exe";
            pg.StartInfo.Arguments = "/c timeout 20 ";
            pg.StartInfo.CreateNoWindow = true;
            pg.Start();
            richTextBox1.Refresh();
            pg.WaitForExit();

            Process p14 = new Process();
            p14.StartInfo.UseShellExecute = false;
            p14.StartInfo.RedirectStandardOutput = true;
            p14.StartInfo.FileName = "cmd.exe";
            p14.StartInfo.Arguments = "/c echo Rebooting to twrp-3.4.. ";
            p14.StartInfo.CreateNoWindow = true;
            p14.Start();
            richTextBox1.Text = richTextBox1.Text + p14.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p14.WaitForExit();

            Process p15 = new Process();
            p15.StartInfo.UseShellExecute = false;
            p15.StartInfo.RedirectStandardOutput = true;
            p15.StartInfo.FileName = "cmd.exe";
            p15.StartInfo.Arguments = "/c fastboot flash boot bin//twrp-3.4.0-0-DRG_sprout-11.0-20200909.img && fastboot reboot ";
            p15.StartInfo.CreateNoWindow = true;
            p15.Start();
            richTextBox1.Text = richTextBox1.Text + p15.StandardOutput.ReadToEnd();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
            richTextBox1.Refresh();
            p15.WaitForExit();
        }
    }
}
