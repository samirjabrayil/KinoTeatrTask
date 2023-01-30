using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoTeatrTask.Models
{
    internal class Film
    {
        public Film[] Films { get; set; } = new Film[2];
        public string FilmOnScreen { get; set; }
        public string FilmGenre { get; set; }
        public string FilmLanguage { get; set; }
        public string FilmReleaseDate { get; set; }
        public string FilmDirector { get; set; }
        public int FilmBoxoffice { get; set; }
        public string FilmBaseOn { get; set; }
        public string FilmCountry { get; set; }

        public override string ToString()
        {
            return $"{Films[2]}{FilmOnScreen}+\"n\" {FilmGenre}+\"n\"{FilmReleaseDate}+\"n\"{FilmDirector}+\"n\"{FilmBoxoffice}+\"n\"{FilmBaseOn}+\"n\"{FilmCountry}";
        }

    }
}
