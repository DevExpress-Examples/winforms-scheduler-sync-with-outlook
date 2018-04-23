using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SyncWithOutlook {
    public partial class SyncronizationOptionForm : Form {
        public static bool AllowCreateAppointmentInScheduler;
        public static bool AllowUpdateAppointmentInScheduler;
        public static bool AllowRemoveAppointmentInScheduler;

        public static bool AllowCreateAppointmentInOutlook;
        public static bool AllowUpdateAppointmentInOutlook;
        public static bool AllowRemoveAppointmentInOutlook;

        public SyncronizationOptionForm() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void SyncronizationOptionForm_Load(object sender, EventArgs e) {
            checkEditAllowCreateOutllok.EditValue = SyncronizationOptionForm.AllowCreateAppointmentInOutlook;
            checkEditAllowCreateScheduler.EditValue = SyncronizationOptionForm.AllowCreateAppointmentInScheduler;
            checkEditAllowRemoveOutlook.EditValue = SyncronizationOptionForm.AllowRemoveAppointmentInOutlook;
            checkEditAllowRemoveScheduler.EditValue = SyncronizationOptionForm.AllowRemoveAppointmentInScheduler;
            checkEditAllowUpdateOutlook.EditValue = SyncronizationOptionForm.AllowUpdateAppointmentInOutlook;
            checkEditAllowUpdateScheduler.EditValue = SyncronizationOptionForm.AllowUpdateAppointmentInScheduler;
        }

        protected override void OnClosing(CancelEventArgs e) {
            SyncronizationOptionForm.AllowCreateAppointmentInOutlook = (bool)checkEditAllowCreateOutllok.EditValue;
            SyncronizationOptionForm.AllowCreateAppointmentInScheduler = (bool)checkEditAllowCreateScheduler.EditValue;
            SyncronizationOptionForm.AllowRemoveAppointmentInOutlook = (bool)checkEditAllowRemoveOutlook.EditValue;
            SyncronizationOptionForm.AllowRemoveAppointmentInScheduler = (bool)checkEditAllowRemoveScheduler.EditValue;
            SyncronizationOptionForm.AllowUpdateAppointmentInOutlook = (bool)checkEditAllowUpdateOutlook.EditValue;
            SyncronizationOptionForm.AllowUpdateAppointmentInScheduler = (bool)checkEditAllowUpdateScheduler.EditValue;
            base.OnClosing(e);
        }
    }
}
