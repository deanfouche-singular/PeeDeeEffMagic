namespace PeeDeeEffMagic
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();

      IronPdf.License.LicenseKey = "IRONPDF.SINGULARSYSTEMSPTYLTD.IRO210316.1493.35155.613012-90CB3CDFD6-DSITTE2ZN5KUFTR-SRHWCRWMYDJN-WF4HF3IY45ZI-ZPJPT6EJTSCI-DTK7SHBAWUWL-N75ETV-LE7PCSVCFWGOUA-AGENCY.10APP.4YR-FUYOAB.RENEW.SUPPORT.15.MAR.2025";
      Application.Run(new MainForm());
    }
  }
}