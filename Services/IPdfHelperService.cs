namespace PeeDeeEffMagic.Services
{
  internal interface IPdfHelperService
  {
    void FlattenPdf();

    void MergePdf();

    void EditPdfFormFields();

    void SignPdf();


  }
}
