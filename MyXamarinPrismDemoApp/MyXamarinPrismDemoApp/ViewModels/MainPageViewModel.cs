using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyXamarinPrismDemoApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		private INavigationService _navigationService { get; }

		public DelegateCommand NavigateToSpeakPageCommand { get; }

		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
			_navigationService = navigationService;
			NavigateToSpeakPageCommand = new DelegateCommand(NavigateToSpeakPage);

		}
		private void NavigateToSpeakPage()
		{
			_navigationService.NavigateAsync("SpeakPage");
		}
	}
}
