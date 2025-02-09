using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        VipclubsContext Context;
        public List<Club> clubs;

        public event PropertyChangedEventHandler? PropertyChanged;
        void Signal([CallerMemberName] string prop = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        public List<Club> Clubs
        {
            get => clubs;
            set { clubs = value;
                Signal();
            }   
      
        }
        public MainWindow()
        {
            InitializeComponent();
            clubs = new List<Club>() { 
            new Club(){ Id = 1, Title = "Clud 'Dungeon Masters'", Description = "ырвирсолыиволсиывсол",  },
            new Club(){Id = 1, Title = "ладно это просто проверка", Description = "Он — тот самый, кого все знают по ярким вспышкам оранжевого меха и широко распахнутых глаз. Этот бандикутоподобный парень носит на лице выражение вечного азарта, словно всегда готов сорваться с места и ринуться навстречу новому вызову. Его глаза, напоминающие два больших блюдца, сверкают решимостью и жаждой приключений. Уши, направленные вперёд, словно антенны, настроены на поиск новых опасностей.\r\n\r\nВнешность его уникальна: смесь бандикута и енота, создающая впечатление одновременно дикого и добродушного существа. Его улыбка, растягивающаяся от уха до уха, показывает, что он всегда находится в боевой готовности, будь то прыжок на врага или шутливая перепалка с другом.\r\n\r\nЧто касается одежды, то здесь всё предельно просто: шорты и ремень с массивной пряжкой. Никаких лишних деталей, только то, что нужно для дела. Этот стиль подчёркивает его готовность к любому испытанию, демонстрируя уверенность и силу характера.\r\n\r\nВ итоге, этот парень — олицетворение энергии, скорости и дерзости. Его внешность заявляет: «Я здесь, чтобы действовать, а не сидеть сложа руки»",},
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            new Club(){ Id = 1, Title = "ghjdthrf", Description = "проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка проверка ",  },
            };
           
          
            DataContext = this;
            //Content = new VipclubsContext();
            // Я ОЧЕНЬ ХОЧУ ОТПРАВИТЬ ПЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖЖ
        }
    }
}