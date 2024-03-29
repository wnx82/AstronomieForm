﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstronomieForm
{
    public class Galaxie
    {
		#region Attributs
		private string _nom;
		private static List<Planete> _lstPlanetes;
        public static List<Galaxie> _lstGalaxies;
        #endregion

        #region Accesseurs
        public static List<Planete> lstPlanetes
		{
			get { return _lstPlanetes; }
			set { _lstPlanetes = value; }
		}
        public static List<Galaxie> lstGalaxie
        {
            get { return _lstGalaxies; }
            set { _lstGalaxies = value; }
        }



        public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}
		#endregion

		public Galaxie() { }
		public Galaxie(string nom):base()
		{
			_nom = nom;
		}


		#region Méthodes publiques
		public string Description()
		{
			return $"Je suis la galaxie {Nom} et je possède {lstPlanetes.Count} planètes.";

        }
		#endregion

	}
}
