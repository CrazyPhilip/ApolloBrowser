using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ApolloBrowser.Controls
{
    public class TabItemAdd : TabItem
    {
        static TabItemAdd()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TabItemAdd), new FrameworkPropertyMetadata(typeof(TabItemAdd)));
        }

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.SetValue(e.Property, e.NewValue);
        }

        /// <summary>
        /// 是否可以关闭
        /// </summary>
        public bool IsCanAdd
        {
            get { return (bool)GetValue(IsCanAddProperty); }
            set { SetValue(IsCanAddProperty, value); }
        }

        public static readonly DependencyProperty IsCanAddProperty =
            DependencyProperty.Register("IsCanAdd", typeof(bool), typeof(TabItemAdd), new PropertyMetadata(true, OnPropertyChanged));

        /// <summary>
        /// 关闭的图标
        /// </summary>
        public ImageSource AddIcon
        {
            get { return (ImageSource)GetValue(AddIconProperty); }
            set { SetValue(AddIconProperty, value); }
        }

        public static readonly DependencyProperty AddIconProperty =
            DependencyProperty.Register("AddIcon", typeof(ImageSource), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 正常背景色
        /// </summary>
        public SolidColorBrush NormalBackground
        {
            get { return (SolidColorBrush)GetValue(NormalBackgroundProperty); }
            set { SetValue(NormalBackgroundProperty, value); }
        }

        public static readonly DependencyProperty NormalBackgroundProperty =
            DependencyProperty.Register("NormalBackground", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 悬浮背景色
        /// </summary>
        public SolidColorBrush OverBackgound
        {
            get { return (SolidColorBrush)GetValue(OverBackgoundProperty); }
            set { SetValue(OverBackgoundProperty, value); }
        }

        public static readonly DependencyProperty OverBackgoundProperty =
            DependencyProperty.Register("OverBackgound", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 选中背景色
        /// </summary>
        public SolidColorBrush SelectedBackgound
        {
            get { return (SolidColorBrush)GetValue(SelectedBackgoundProperty); }
            set { SetValue(SelectedBackgoundProperty, value); }
        }

        public static readonly DependencyProperty SelectedBackgoundProperty =
            DependencyProperty.Register("SelectedBackgound", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 默认前景色
        /// </summary>
        public SolidColorBrush NormalForeground
        {
            get { return (SolidColorBrush)GetValue(NormalForegroundProperty); }
            set { SetValue(NormalForegroundProperty, value); }
        }

        public static readonly DependencyProperty NormalForegroundProperty =
            DependencyProperty.Register("NormalForeground", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 悬浮前景色
        /// </summary>
        public SolidColorBrush OverForeground
        {
            get { return (SolidColorBrush)GetValue(OverForegroundProperty); }
            set { SetValue(OverForegroundProperty, value); }
        }

        public static readonly DependencyProperty OverForegroundProperty =
            DependencyProperty.Register("OverForeground", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));

        /// <summary>
        /// 选中前景色
        /// </summary>
        public SolidColorBrush SelectedForeground
        {
            get { return (SolidColorBrush)GetValue(SelectedForegroundProperty); }
            set { SetValue(SelectedForegroundProperty, value); }
        }

        public static readonly DependencyProperty SelectedForegroundProperty =
            DependencyProperty.Register("SelectedForeground", typeof(SolidColorBrush), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));


        /// <summary>
        /// 控件圆角
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(TabItemAdd), new PropertyMetadata(new CornerRadius(0), OnPropertyChanged));


        /// <summary>
        /// 前置Logo
        /// </summary>
        public ImageSource LogoIcon
        {
            get { return (ImageSource)GetValue(LogoIconProperty); }
            set { SetValue(LogoIconProperty, value); }
        }

        public static readonly DependencyProperty LogoIconProperty =
            DependencyProperty.Register("LogoIcon", typeof(ImageSource), typeof(TabItemAdd), new PropertyMetadata(null, OnPropertyChanged));



        /// <summary>
        /// 前置Logo宽度
        /// </summary>
        public double LogoIconWidth
        {
            get { return (double)GetValue(LogoIconWidthProperty); }
            set { SetValue(LogoIconWidthProperty, value); }
        }

        public static readonly DependencyProperty LogoIconWidthProperty =
            DependencyProperty.Register("LogoIconWidth", typeof(double), typeof(TabItemAdd), new PropertyMetadata(double.Parse("0"), OnPropertyChanged));


        /// <summary>
        /// 前置Logo高度
        /// </summary>
        public double LogoIconHeigth
        {
            get { return (double)GetValue(LogoIconHeigthProperty); }
            set { SetValue(LogoIconHeigthProperty, value); }
        }

        public static readonly DependencyProperty LogoIconHeigthProperty =
            DependencyProperty.Register("LogoIconHeigth", typeof(double), typeof(TabItemAdd), new PropertyMetadata(double.Parse("0"), OnPropertyChanged));


        /// <summary>
        /// LogoPadding
        /// </summary>
        public Thickness LogoPadding
        {
            get { return (Thickness)GetValue(LogoPaddingProperty); }
            set { SetValue(LogoPaddingProperty, value); }
        }

        public static readonly DependencyProperty LogoPaddingProperty =
            DependencyProperty.Register("LogoPadding", typeof(Thickness), typeof(TabItemAdd), new PropertyMetadata(new Thickness(0), OnPropertyChanged));

        /// <summary>
        /// 关闭item事件
        /// </summary>
        public event RoutedEventHandler AddItem
        {
            add { AddHandler(AddItemEvent, value); }
            remove { RemoveHandler(AddItemEvent, value); }
        }
        public static readonly RoutedEvent AddItemEvent =
            EventManager.RegisterRoutedEvent("AddItem", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TabItemAdd));

        /// <summary>
        /// 关闭项的右键菜单
        /// </summary>
        public ContextMenu ItemContextMenu { get; set; }

        Border ItemBorder;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            ItemBorder = Template.FindName("_bordertop", this) as Border;
            if (ItemContextMenu != null)
            {
                ItemBorder.ContextMenu = ItemContextMenu;
            }
        }
    }
}
