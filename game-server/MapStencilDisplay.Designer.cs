﻿namespace Dargon.NBound {
   partial class MapStencilDisplay {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         this.fontDialog1 = new System.Windows.Forms.FontDialog();
         this.imageTabs = new System.Windows.Forms.TabControl();
         this.tabPage1 = new System.Windows.Forms.TabPage();
         this.tabPage2 = new System.Windows.Forms.TabPage();
         this.imageTabs.SuspendLayout();
         this.SuspendLayout();
         // 
         // imageTabs
         // 
         this.imageTabs.Controls.Add(this.tabPage1);
         this.imageTabs.Controls.Add(this.tabPage2);
         this.imageTabs.Dock = System.Windows.Forms.DockStyle.Fill;
         this.imageTabs.Location = new System.Drawing.Point(0, 0);
         this.imageTabs.Name = "imageTabs";
         this.imageTabs.SelectedIndex = 0;
         this.imageTabs.Size = new System.Drawing.Size(608, 329);
         this.imageTabs.TabIndex = 0;
         // 
         // tabPage1
         // 
         this.tabPage1.Location = new System.Drawing.Point(4, 22);
         this.tabPage1.Name = "tabPage1";
         this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage1.Size = new System.Drawing.Size(600, 303);
         this.tabPage1.TabIndex = 0;
         this.tabPage1.Text = "tabPage1";
         this.tabPage1.UseVisualStyleBackColor = true;
         // 
         // tabPage2
         // 
         this.tabPage2.Location = new System.Drawing.Point(4, 22);
         this.tabPage2.Name = "tabPage2";
         this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
         this.tabPage2.Size = new System.Drawing.Size(192, 74);
         this.tabPage2.TabIndex = 1;
         this.tabPage2.Text = "tabPage2";
         this.tabPage2.UseVisualStyleBackColor = true;
         // 
         // MapStencilDisplay
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(608, 329);
         this.Controls.Add(this.imageTabs);
         this.Name = "MapStencilDisplay";
         this.Text = "MapStencilDisplay";
         this.imageTabs.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.FontDialog fontDialog1;
      private System.Windows.Forms.TabControl imageTabs;
      private System.Windows.Forms.TabPage tabPage1;
      private System.Windows.Forms.TabPage tabPage2;
   }
}