using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using ZeroPlay.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ZeroPlay.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {

        private HomeViewModel _viewModel;

        public HomePage()
        {
            this.InitializeComponent();

            // ������ͼģ��ʵ��
            _viewModel = new HomeViewModel();

            // ����ҳ�������������Ϊ��ͼģ�ͣ�����������ݰ�
            this.DataContext = _viewModel;

            // ʹ��BindingOperations.SetBinding������FlipView��ItemsSource��
            BindingOperations.SetBinding(flipViewVertical, FlipView.ItemsSourceProperty, new Binding
            {
                Path = new PropertyPath("MediaItems"),
                Source = _viewModel
            });
        }
    }

    // ����һ���򵥵��������࣬���ڴ洢ÿ��FlipViewչʾ���Ӧ��ͼ���������Ϣ

}
