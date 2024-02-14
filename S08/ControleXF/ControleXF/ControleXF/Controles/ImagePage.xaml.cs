using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent();

			AdicionarImagem();
		}

		private void AdicionarImagem()
		{
			var imagem = new Image
			{
				Source = ImageSource.FromFile("the_college_dropout.png"),
				Aspect = Aspect.AspectFit,
				IsOpaque = true
			};

			StackLayout_Imagens.Children.Add(imagem);
		}
	}
}