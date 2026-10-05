namespace IronPeak.Presentacion;

public class FormPrincipal : Form
{
    public FormPrincipal()
    {
        Text = "IronPeak Fitness Club";
        Width = 900;
        Height = 600;
        StartPosition = FormStartPosition.CenterScreen;

        var mensaje = new Label
        {
            Text = "IronPeak Fitness Club\nEstructura inicial del proyecto",
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            Font = new Font("Segoe UI", 18)
        };

        Controls.Add(mensaje);
    }
}
