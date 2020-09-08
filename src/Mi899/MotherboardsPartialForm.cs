﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mi899.Data;
using System.Linq;

namespace Mi899
{
    public partial class MotherboardsPartialForm : UserControl
    {
        private Model _model;

        public MotherboardsPartialForm(Model model)
        {
            _model = model ?? throw new ArgumentNullException(nameof(model));
            InitializeComponent();
            InitializeDataGridComponent();
        }

        private void MotherboardsPartialForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeDataGridComponent()
        {
            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IMotherboard.Id),
                DataPropertyName = nameof(IMotherboard.Id),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic,
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IMotherboard.Brand),
                DataPropertyName = nameof(IMotherboard.Brand),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IMotherboard.Model),
                DataPropertyName = nameof(IMotherboard.Model),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = nameof(IMotherboard.Version),
                DataPropertyName = nameof(IMotherboard.Version),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "FPT",
                ToolTipText = "Indicates whether this motherboard is compatible with FPT",
                DataPropertyName = nameof(IMotherboard.IsFptCompatible),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            grdMotherboards.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                HeaderText = "AfuWin",
                ToolTipText = "Indicates whether this motherboard is compatible with AfuWin",
                DataPropertyName = nameof(IMotherboard.IsAfuWinCompatible),
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                SortMode = DataGridViewColumnSortMode.Automatic
            });

            bsMotherboards.DataSource = new GenericBindingList<IMotherboard>(_model.Motherboards);
            grdMotherboards.AutoGenerateColumns = false;
            grdMotherboards.DataSource = bsMotherboards;
            grdMotherboards.AutoResizeColumns();
        }
    }
}