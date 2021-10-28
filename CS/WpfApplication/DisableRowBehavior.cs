using DevExpress.Mvvm.UI.Interactivity;
using DevExpress.Xpf.Grid;

namespace WpfApplication {
    public class DisableRowBehavior : Behavior<TableView> {
        protected override void OnAttached() {
            base.OnAttached();
            AssociatedObject.ShowingEditor += OnEditorShowing;
        }
        protected override void OnDetaching() {
            AssociatedObject.ShowingEditor -= OnEditorShowing;
            base.OnDetaching();
        }

        void OnEditorShowing(object sender, ShowingEditorEventArgs e) {
            e.Cancel = !(AssociatedObject.DataControl.CurrentItem as Item).AllowEdit;
        }
    }
}
