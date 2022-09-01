using MasterServer.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MasterServer
{
    internal class MainWindowVM : INotifyPropertyChanged
    {
        /// <summary>
        /// 데이타 바인팅 필요 함수
        /// </summary>
        /// <param name="porpName"> 수정할 바인딩 변수 이름 </param>
        protected void OnPropertyChanged(string porpName)
        {
            var temp = PropertyChanged;
            if (temp != null)
                temp(this, new PropertyChangedEventArgs(porpName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        //private ICommand? btnConnect;
        ///// <summary>
        ///// 
        ///// </summary>
        //public ICommand BtnConnect
        //{
        //    get
        //    {
        //        return (btnConnect) ?? (this.btnConnect = new DelegateCommand(ActiveBtnProcessing));
        //    }
        //}


        private string? clientIP;
        /// <summary>
        /// ClientIP
        /// </summary>
        public string ClientIP
        {
            get
            {
                return clientIP;
            }
            set
            {
                clientIP = value;
                OnPropertyChanged("ClientIP");
            }
        }

        private string? clientPort;
        /// <summary>
        /// ClientPORT
        /// </summary>
        public string ClientPort
        {
            get
            {
                return clientPort;
            }
            set
            {
                clientPort = value;
                OnPropertyChanged("ClientPort");
            }
        }

        private string? commandText;
        /// <summary>
        /// ClientPORT
        /// </summary>
        public string CommandText
        {
            get
            {
                return commandText;
            }
            set
            {
                commandText = value;
                OnPropertyChanged("CommandText");
            }
        }


        private ArrayList consolArrayData;

        public ArrayList ConsolArrayData
        {
            get
            {
                return consolArrayData;
            }
            set
            {
                consolArrayData = value;
                OnPropertyChanged("ConsolArrayData");
            }
        }

        public MainWindowVM()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("test 1");
            arrayList.Add("test 2");
            arrayList.Add("test 3");
            arrayList.Add("test 4");
            arrayList.Add("test 5");
            arrayList.Add("test 6");
            arrayList.Add("test 7");
            arrayList.Add("test 8");
            arrayList.Add("test 9");
            arrayList.Add("test 10");

            ConsolArrayData = arrayList;
        }
    }
}
