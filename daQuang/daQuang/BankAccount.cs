using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daQuang
{
    class BankAccount
    {
        //fields
        private string m_ID;
        private string m_Password;
        private string m_TenTK;
        private string m_loaiTien;
        private double _soDu;

        public string ID
        {
            get
            {
                return m_ID;
            }

            set
            {
                m_ID = value;
            }
        }

        public string Password
        {
            get
            {
                return m_Password;
            }

            set
            {
                m_Password = value;
            }
        }

        public string TenTK
        {
            get
            {
                return m_TenTK;
            }

            set
            {
                m_TenTK = value;
            }
        }

        public string LoaiTien
        {
            get
            {
                return m_loaiTien;
            }

            set
            {
                m_loaiTien = value;
            }
        }

        public double SoDu
        {
            get
            {
                return _soDu;
            }

            set
            {
                _soDu = value;
            }
        }
        
        public BankAccount() { }

        public BankAccount(string m_ID, string m_Password, string m_TenTK, string m_loaiTien, double _soDu)
        {
            this.m_ID = m_ID;
            this.m_Password = m_Password;
            this.m_TenTK = m_TenTK;
            this.m_loaiTien = m_loaiTien;
            this._soDu = _soDu;
        }

        public string toString()
        {
            return $"\tID: {ID}\n\tPassword: {Password}\n\tTen chu the: {TenTK}\n\tLoai tien:{LoaiTien}\n\tSo du: {SoDu}\n";
        }

    }
}
