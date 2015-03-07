﻿using DataPool;
namespace AdvaMACSystem
{
    partial class VirtualSetForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.il_Presure = new ComCtrls.ImageLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.il_Position = new ComCtrls.ImageLabel();
            this.comboBoxcylinderState = new System.Windows.Forms.ComboBox();
            this.comboBoxMachLockState = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.il_Pressure_Pump = new ComCtrls.ImageLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.il_Voltage = new ComCtrls.ImageLabel();
            this.rb__PowerSupply = new System.Windows.Forms.CheckBox();
            this.rb_Limit_5 = new System.Windows.Forms.CheckBox();
            this.rb_Limit_10 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_Warn_LowPosition = new System.Windows.Forms.CheckBox();
            this.rb_Warn_HighPosition = new System.Windows.Forms.CheckBox();
            this.rb_Warn_LowPressure = new System.Windows.Forms.CheckBox();
            this.rb_Warn_HighPressure = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_PumpErr = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rb_Error_cylinder_extend = new System.Windows.Forms.CheckBox();
            this.rb_Error_MachLock_retract = new System.Windows.Forms.CheckBox();
            this.rb_Error_Pump = new System.Windows.Forms.CheckBox();
            this.rb_Error_cylinder_retract = new System.Windows.Forms.CheckBox();
            this.rb_Error_MachLock_extend = new System.Windows.Forms.CheckBox();
            this.rb_Error_PressureSenser = new System.Windows.Forms.CheckBox();
            this.rb_Error_PositionSenser = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Items.Add("#1 泵站");
            this.comboBox1.Items.Add("#2 泵站");
            this.comboBox1.Items.Add("#3 泵站");
            this.comboBox1.Items.Add("#4 泵站");
            this.comboBox1.Location = new System.Drawing.Point(55, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Items.Add("#1 油缸");
            this.comboBox2.Items.Add("#2 油缸");
            this.comboBox2.Items.Add("#3 油缸");
            this.comboBox2.Items.Add("#4 油缸");
            this.comboBox2.Items.Add("#5 油缸");
            this.comboBox2.Items.Add("#6 油缸");
            this.comboBox2.Items.Add("#7 油缸");
            this.comboBox2.Items.Add("#8 油缸");
            this.comboBox2.Location = new System.Drawing.Point(217, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndex = 0;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.Text = "subID";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.Text = "油缸压力当前值";
            // 
            // il_Presure
            // 
            this.il_Presure.BackColor = System.Drawing.Color.White;
            this.il_Presure.BackImg = null;
            this.il_Presure.Checked = false;
            this.il_Presure.IMGContainer = null;
            this.il_Presure.Layout = ComCtrls.KTLayout.GlyphTop;
            this.il_Presure.Location = new System.Drawing.Point(143, 71);
            this.il_Presure.Name = "il_Presure";
            this.il_Presure.Size = new System.Drawing.Size(104, 20);
            this.il_Presure.TabIndex = 6;
            this.il_Presure.Tag = DataPool.CmdDataType.cdtPressure_Real_3001_3008;
            this.il_Presure.Text = "0";
            this.il_Presure.TextX = -1F;
            this.il_Presure.TextY = -1F;
            this.il_Presure.TransParent = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(253, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.Text = "油缸当前长度值";
            // 
            // il_Position
            // 
            this.il_Position.BackColor = System.Drawing.Color.White;
            this.il_Position.BackImg = null;
            this.il_Position.Checked = false;
            this.il_Position.IMGContainer = null;
            this.il_Position.Layout = ComCtrls.KTLayout.GlyphTop;
            this.il_Position.Location = new System.Drawing.Point(377, 71);
            this.il_Position.Name = "il_Position";
            this.il_Position.Size = new System.Drawing.Size(104, 20);
            this.il_Position.TabIndex = 9;
            this.il_Position.Tag = DataPool.CmdDataType.cdtPosition_Real_3101_3108;
            this.il_Position.Text = "0";
            this.il_Position.TextX = -1F;
            this.il_Position.TextY = -1F;
            this.il_Position.TransParent = false;
            // 
            // comboBoxcylinderState
            // 
            this.comboBoxcylinderState.Items.Add("0：停");
            this.comboBoxcylinderState.Items.Add("1：伸");
            this.comboBoxcylinderState.Items.Add("2：缩");
            this.comboBoxcylinderState.Location = new System.Drawing.Point(143, 106);
            this.comboBoxcylinderState.Name = "comboBoxcylinderState";
            this.comboBoxcylinderState.Size = new System.Drawing.Size(100, 23);
            this.comboBoxcylinderState.TabIndex = 10;
            this.comboBoxcylinderState.SelectedIndex  = 0;
            this.comboBoxcylinderState.Tag = DataPool.CmdDataType.cdtcylinderState_Real_3201_3208;
            // 
            // comboBoxMachLockState
            // 
            this.comboBoxMachLockState.Items.Add("0：停");
            this.comboBoxMachLockState.Items.Add("1：伸");
            this.comboBoxMachLockState.Items.Add("2：缩");
            this.comboBoxMachLockState.Location = new System.Drawing.Point(381, 106);
            this.comboBoxMachLockState.Name = "comboBoxMachLockState";
            this.comboBoxMachLockState.Size = new System.Drawing.Size(100, 23);
            this.comboBoxMachLockState.TabIndex = 11;
            this.comboBoxMachLockState.SelectedIndex = 0;
            this.comboBoxMachLockState.Tag = DataPool.CmdDataType.cdtMachLockState_Real_3201_3208;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.Text = "油缸运行状态";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(257, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.Text = "机械锁运行状态";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.Text = "泵站压力";
            // 
            // il_Pressure_Pump
            // 
            this.il_Pressure_Pump.BackColor = System.Drawing.Color.White;
            this.il_Pressure_Pump.BackImg = null;
            this.il_Pressure_Pump.Checked = false;
            this.il_Pressure_Pump.IMGContainer = null;
            this.il_Pressure_Pump.Layout = ComCtrls.KTLayout.GlyphTop;
            this.il_Pressure_Pump.Location = new System.Drawing.Point(143, 137);
            this.il_Pressure_Pump.Name = "il_Pressure_Pump";
            this.il_Pressure_Pump.Size = new System.Drawing.Size(104, 20);
            this.il_Pressure_Pump.TabIndex = 6;
            this.il_Pressure_Pump.Tag = DataPool.CmdDataType.cdtPressure_Pump_Real_3301_3304;
            this.il_Pressure_Pump.Text = "0";
            this.il_Pressure_Pump.TextX = -1F;
            this.il_Pressure_Pump.TextY = -1F;
            this.il_Pressure_Pump.TransParent = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(257, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.Text = "控制器电压";
            // 
            // il_Voltage
            // 
            this.il_Voltage.BackColor = System.Drawing.Color.White;
            this.il_Voltage.BackImg = null;
            this.il_Voltage.Checked = false;
            this.il_Voltage.IMGContainer = null;
            this.il_Voltage.Layout = ComCtrls.KTLayout.GlyphTop;
            this.il_Voltage.Location = new System.Drawing.Point(381, 139);
            this.il_Voltage.Name = "il_Voltage";
            this.il_Voltage.Size = new System.Drawing.Size(104, 20);
            this.il_Voltage.TabIndex = 6;
            this.il_Voltage.Tag = DataPool.CmdDataType.cdtVoltage_Real_3301_3304;
            this.il_Voltage.Text = "0";
            this.il_Voltage.TextX = -1F;
            this.il_Voltage.TextY = -1F;
            this.il_Voltage.TransParent = false;
            // 
            // rb__PowerSupply
            // 
            this.rb__PowerSupply.Location = new System.Drawing.Point(19, 177);
            this.rb__PowerSupply.Name = "rb__PowerSupply";
            this.rb__PowerSupply.Size = new System.Drawing.Size(298, 20);
            this.rb__PowerSupply.TabIndex = 16;
            this.rb__PowerSupply.Tag = DataPool.CmdDataType.cdtPowerSupply_3301_3304;
            this.rb__PowerSupply.Text = "控制器检测当前供电 0：市电 1：发电机";
            // 
            // rb_Limit_5
            // 
            this.rb_Limit_5.Location = new System.Drawing.Point(19, 203);
            this.rb_Limit_5.Name = "rb_Limit_5";
            this.rb_Limit_5.Size = new System.Drawing.Size(176, 20);
            this.rb_Limit_5.TabIndex = 16;
            this.rb_Limit_5.Tag = DataPool.CmdDataType.cdtLimit_5_3301_3304;
            this.rb_Limit_5.Text = "油缸5mm接近开关限位";
            // 
            // rb_Limit_10
            // 
            this.rb_Limit_10.Location = new System.Drawing.Point(273, 203);
            this.rb_Limit_10.Name = "rb_Limit_10";
            this.rb_Limit_10.Size = new System.Drawing.Size(188, 20);
            this.rb_Limit_10.TabIndex = 16;
            this.rb_Limit_10.Tag = DataPool.CmdDataType.cdtLimit_10_3301_3304;
            this.rb_Limit_10.Text = "油缸10mm接近开关限位";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rb_Warn_LowPosition);
            this.panel1.Controls.Add(this.rb_Warn_HighPosition);
            this.panel1.Controls.Add(this.rb_Warn_LowPressure);
            this.panel1.Controls.Add(this.rb_Warn_HighPressure);
            this.panel1.Location = new System.Drawing.Point(19, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 130);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(53, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.Text = "报警";
            // 
            // rb_Warn_LowPosition
            // 
            this.rb_Warn_LowPosition.Location = new System.Drawing.Point(3, 104);
            this.rb_Warn_LowPosition.Name = "rb_Warn_LowPosition";
            this.rb_Warn_LowPosition.Size = new System.Drawing.Size(132, 20);
            this.rb_Warn_LowPosition.TabIndex = 0;
            this.rb_Warn_LowPosition.Tag = DataPool.CmdDataType.cdtWarn_LowPosition_3401_3404;
            this.rb_Warn_LowPosition.Text = "油缸长度过低";
            // 
            // rb_Warn_HighPosition
            // 
            this.rb_Warn_HighPosition.Location = new System.Drawing.Point(3, 78);
            this.rb_Warn_HighPosition.Name = "rb_Warn_HighPosition";
            this.rb_Warn_HighPosition.Size = new System.Drawing.Size(132, 20);
            this.rb_Warn_HighPosition.TabIndex = 0;
            this.rb_Warn_HighPosition.Tag = DataPool.CmdDataType.cdtWarn_HighPosition_3401_3404;
            this.rb_Warn_HighPosition.Text = "油缸长度过高";
            // 
            // rb_Warn_LowPressure
            // 
            this.rb_Warn_LowPressure.Location = new System.Drawing.Point(3, 52);
            this.rb_Warn_LowPressure.Name = "rb_Warn_LowPressure";
            this.rb_Warn_LowPressure.Size = new System.Drawing.Size(132, 20);
            this.rb_Warn_LowPressure.TabIndex = 0;
            this.rb_Warn_LowPressure.Tag = DataPool.CmdDataType.cdtWarn_LowPressure_3401_3404;
            this.rb_Warn_LowPressure.Text = "油缸压力过低";
            // 
            // rb_Warn_HighPressure
            // 
            this.rb_Warn_HighPressure.Location = new System.Drawing.Point(3, 26);
            this.rb_Warn_HighPressure.Name = "rb_Warn_HighPressure";
            this.rb_Warn_HighPressure.Size = new System.Drawing.Size(132, 20);
            this.rb_Warn_HighPressure.TabIndex = 0;
            this.rb_Warn_HighPressure.Tag = DataPool.CmdDataType.cdtWarn_HighPressure_3401_3404;
            this.rb_Warn_HighPressure.Text = "油缸压力过高";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox_PumpErr);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.rb_Error_cylinder_extend);
            this.panel2.Controls.Add(this.rb_Error_MachLock_retract);
            this.panel2.Controls.Add(this.rb_Error_Pump);
            this.panel2.Controls.Add(this.rb_Error_cylinder_retract);
            this.panel2.Controls.Add(this.rb_Error_MachLock_extend);
            this.panel2.Controls.Add(this.rb_Error_PressureSenser);
            this.panel2.Controls.Add(this.rb_Error_PositionSenser);
            this.panel2.Location = new System.Drawing.Point(257, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 130);
            // 
            // comboBox_PumpErr
            // 
            this.comboBox_PumpErr.Items.Add("泵站电动机启动线路短路\t\t        ");
            this.comboBox_PumpErr.Items.Add("泵站电动机启动线路断路\t\t\t    ");
            this.comboBox_PumpErr.Items.Add("泵站冗余电磁阀线路短路\t\t\t    ");
            this.comboBox_PumpErr.Items.Add("泵站冗余电磁阀线路断路\t\t\t    ");
            this.comboBox_PumpErr.Items.Add("泵站机械锁马达电磁阀线路短路\t\t");
            this.comboBox_PumpErr.Items.Add("泵站机械锁马达电磁阀线路断路\t\t");
            this.comboBox_PumpErr.Items.Add("控制器发电机启动线路短路\t\t\t");
            this.comboBox_PumpErr.Items.Add("控制器发电机启动线路断路\t\t\t");
            this.comboBox_PumpErr.Items.Add("泵站比例阀线路短路\t\t                ");
            this.comboBox_PumpErr.Items.Add("泵站比例阀线路断路\t            ");
            this.comboBox_PumpErr.Location = new System.Drawing.Point(39, 22);
            this.comboBox_PumpErr.Name = "comboBox_PumpErr";
            this.comboBox_PumpErr.Size = new System.Drawing.Size(122, 23);
            this.comboBox_PumpErr.TabIndex = 2;
            this.comboBox_PumpErr.SelectedIndexChanged += new System.EventHandler(this.comboBox_PumpErr_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(120, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.Text = "故障";
            // 
            // rb_Error_cylinder_extend
            // 
            this.rb_Error_cylinder_extend.Location = new System.Drawing.Point(173, 26);
            this.rb_Error_cylinder_extend.Name = "rb_Error_cylinder_extend";
            this.rb_Error_cylinder_extend.Size = new System.Drawing.Size(165, 20);
            this.rb_Error_cylinder_extend.TabIndex = 0;
            this.rb_Error_cylinder_extend.Tag = DataPool.CmdDataType.cdtError_cylinder_extend_3511_3514;
            this.rb_Error_cylinder_extend.Text = "油缸伸出电磁阀线路短路";
            // 
            // rb_Error_MachLock_retract
            // 
            this.rb_Error_MachLock_retract.Location = new System.Drawing.Point(173, 104);
            this.rb_Error_MachLock_retract.Name = "rb_Error_MachLock_retract";
            this.rb_Error_MachLock_retract.Size = new System.Drawing.Size(165, 20);
            this.rb_Error_MachLock_retract.TabIndex = 0;
            this.rb_Error_MachLock_retract.Tag = DataPool.CmdDataType.cdtError_MachLock_retract_3511_3514;
            this.rb_Error_MachLock_retract.Text = "油缸机械锁缩回电磁阀线路短路";
            // 
            // rb_Error_Pump
            // 
            this.rb_Error_Pump.Location = new System.Drawing.Point(16, 53);
            this.rb_Error_Pump.Name = "rb_Error_Pump";
            this.rb_Error_Pump.Size = new System.Drawing.Size(150, 20);
            this.rb_Error_Pump.TabIndex = 0;
            this.rb_Error_Pump.Tag = DataPool.CmdDataType.cdtError_Pump_3501_3504;
            this.rb_Error_Pump.Text = "泵站及控制器 故障";
            // 
            // rb_Error_cylinder_retract
            // 
            this.rb_Error_cylinder_retract.Location = new System.Drawing.Point(173, 52);
            this.rb_Error_cylinder_retract.Name = "rb_Error_cylinder_retract";
            this.rb_Error_cylinder_retract.Size = new System.Drawing.Size(165, 20);
            this.rb_Error_cylinder_retract.TabIndex = 0;
            this.rb_Error_cylinder_retract.Tag = DataPool.CmdDataType.cdtError_cylinder_retract_3511_3514;
            this.rb_Error_cylinder_retract.Text = "油缸缩回电磁阀线路短路";
            // 
            // rb_Error_MachLock_extend
            // 
            this.rb_Error_MachLock_extend.Location = new System.Drawing.Point(173, 78);
            this.rb_Error_MachLock_extend.Name = "rb_Error_MachLock_extend";
            this.rb_Error_MachLock_extend.Size = new System.Drawing.Size(165, 20);
            this.rb_Error_MachLock_extend.TabIndex = 0;
            this.rb_Error_MachLock_extend.Tag = DataPool.CmdDataType.cdtError_MachLock_extend_3511_3514;
            this.rb_Error_MachLock_extend.Text = "油缸机械锁伸出电磁阀线路短路";
            // 
            // rb_Error_PressureSenser
            // 
            this.rb_Error_PressureSenser.Location = new System.Drawing.Point(16, 79);
            this.rb_Error_PressureSenser.Name = "rb_Error_PressureSenser";
            this.rb_Error_PressureSenser.Size = new System.Drawing.Size(150, 20);
            this.rb_Error_PressureSenser.TabIndex = 0;
            this.rb_Error_PressureSenser.Tag = DataPool.CmdDataType.cdtError_PressureSenser_3501_3504;
            this.rb_Error_PressureSenser.Text = "油缸压力传感器故障";
            // 
            // rb_Error_PositionSenser
            // 
            this.rb_Error_PositionSenser.Location = new System.Drawing.Point(16, 105);
            this.rb_Error_PositionSenser.Name = "rb_Error_PositionSenser";
            this.rb_Error_PositionSenser.Size = new System.Drawing.Size(150, 20);
            this.rb_Error_PositionSenser.TabIndex = 0;
            this.rb_Error_PositionSenser.Tag = DataPool.CmdDataType.cdtError_PositionSenser_3501_3504;
            this.rb_Error_PositionSenser.Text = "油缸长度传感器故障";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(495, 177);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 20);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "checkBox1";
            // 
            // VirtualSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(633, 409);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rb_Limit_10);
            this.Controls.Add(this.rb_Limit_5);
            this.Controls.Add(this.rb__PowerSupply);
            this.Controls.Add(this.comboBoxMachLockState);
            this.Controls.Add(this.comboBoxcylinderState);
            this.Controls.Add(this.il_Position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.il_Voltage);
            this.Controls.Add(this.il_Pressure_Pump);
            this.Controls.Add(this.il_Presure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "VirtualSetForm";
            this.Text = "VirtualSetForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ComCtrls.ImageLabel il_Presure;
        private System.Windows.Forms.Label label4;
        private ComCtrls.ImageLabel il_Position;
        private System.Windows.Forms.ComboBox comboBoxcylinderState;
        private System.Windows.Forms.ComboBox comboBoxMachLockState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ComCtrls.ImageLabel il_Pressure_Pump;
        private System.Windows.Forms.Label label8;
        private ComCtrls.ImageLabel il_Voltage;
        private System.Windows.Forms.CheckBox rb__PowerSupply;
        private System.Windows.Forms.CheckBox rb_Limit_5;
        private System.Windows.Forms.CheckBox rb_Limit_10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox rb_Warn_HighPressure;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox rb_Warn_LowPosition;
        private System.Windows.Forms.CheckBox rb_Warn_HighPosition;
        private System.Windows.Forms.CheckBox rb_Warn_LowPressure;
        private System.Windows.Forms.CheckBox rb_Error_cylinder_extend;
        private System.Windows.Forms.CheckBox rb_Error_MachLock_retract;
        private System.Windows.Forms.CheckBox rb_Error_Pump;
        private System.Windows.Forms.CheckBox rb_Error_cylinder_retract;
        private System.Windows.Forms.CheckBox rb_Error_MachLock_extend;
        private System.Windows.Forms.CheckBox rb_Error_PressureSenser;
        private System.Windows.Forms.CheckBox rb_Error_PositionSenser;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_PumpErr;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}