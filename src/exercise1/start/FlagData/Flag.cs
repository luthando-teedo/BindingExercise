using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlagData
{
    /// <summary>
    /// This model object represents a single flag
    /// </summary>
    public class Flag : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Name of the country that this flag belongs to
        /// </summary>
        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private DateTime _dateAdopted;
        private string  _country;
        private string _ImageUrl;
        private bool _Shieds;
        private string _description;
        private Uri _moreInformationUrl;


        public string Country
        {
            get { return _country; }
            set
            {
                if (_country != value)
                {
                    _country = value;

                    RaisePropertyChanged();
                }
            }
        }
        /// <summary>
        /// Image URL for the flag (from resources)
        /// </summary>
        public string ImageUrl 
        {
            get { return _ImageUrl; }
            set{
                if (_ImageUrl != value)
                {
                    _ImageUrl = value;

                    RaisePropertyChanged();
                }
            }
        }
        /// <summary>
        /// The date this flag was adopted
        /// </summary>
        public DateTime DateAdopted
        {
            get { return _dateAdopted; }
            set
            {
                if (_dateAdopted != value)
                {
                    _dateAdopted = value;
                    // Can pass the property name as a string,
                    // -or- let the compiler do it because of the
                    // CallerMemberNameAttribute on the RaisePropertyChanged method.
                    RaisePropertyChanged();
                }
            }
        }
        /// <summary>
        /// Whether the flag includes an image/shield as part of the design
        /// </summary>
        
        public bool IncludesShield
        {
            get { return _Shieds; }
            set
            {
                if (_Shieds != value)
                {
                    _Shieds = value;

                    RaisePropertyChanged();
                }
            }
        }
        /// <summary>
        /// Some trivia or commentary about the flag
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                if (_description != value)
                {
                    _description = value;

                    RaisePropertyChanged();
                }
            }
        }
        /// <summary>
        /// A URL for more information
        /// </summary>
        public Uri MoreInformationUrl
        {
            get { return _moreInformationUrl; }
            set
            {
                if (_moreInformationUrl != value)
                {
                    _moreInformationUrl = value;

                    RaisePropertyChanged();
                }
            }
        }
    }
}
