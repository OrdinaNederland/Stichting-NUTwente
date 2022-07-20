﻿using Ordina.StichtingNuTwente.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordina.StichtingNuTwente.Business.Interfaces
{
    public interface IGastgezinService
    {
        public const string IncludeProperties = "Contact,Contact.Adres,Contact.Reactie,Vluchtelingen,Begeleider,Buddy,PlaatsingsInfo,AanmeldFormulier,IntakeFormulier,Plaatsingen,Plaatsingen.Vrijwilliger,Comments,ContactLogs";

        public bool Save(Gastgezin gastgezin);
        public Gastgezin? GetGastgezin(int id, string includeProperties = IncludeProperties);
        public ICollection<Gastgezin> GetGastgezinnenForVrijwilliger(int vrijwilligerId, IEnumerable<Gastgezin>? gastgezinnen = null);
        public ICollection<Gastgezin> GetAllGastgezinnen(string includeProperties = IncludeProperties);
        public ICollection<Gastgezin> GetDeletedGastgezinnen(string includeProperties = IncludeProperties);
        public Gastgezin UpdateGastgezin(Gastgezin gastgezin, int? id = null);
        public void AddPlaatsing(Plaatsing plaatsing);
        public void UpdatePlaatsing(Plaatsing plaatsing);
        public Plaatsing GetPlaatsing(int id);
        public void CheckOnholdGastgezinnen();
        public List<Plaatsing> GetPlaatsingen(int? gastGezinId = null, PlacementType? type = null, AgeGroup? ageGroup = null);
        public string GetPlaatsingTag(int gastgezinId, PlacementType placementType, Gastgezin? gastgezin = null);
        public void UpdateNote(int gastgezinId, string note);
        public void UpdateVOG(bool hasVOG, int gastgezinId);
        public bool PlaatsingExists(int gastgezinId, Plaatsing plaatsing);
        public void Restore(int gastgezinId);
        public void Delete(int gastgezinId, bool deleteForms, UserDetails user, string comment);
        public string GetPlaatsingenTag(List<Gastgezin> gastgezinnen, PlacementType placementType);
        public void RejectBeingBuddy(Gastgezin gastgezin, string reason, UserDetails userDetails);
    }
}
