using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Champions;
using Utilisateurs;
using System.IO;

namespace Service
{
    public class Manager
    {
        public Manager() { }


        public void Ecrire<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        public void AjouterChampion(string v1, string v2)
        {
            throw new NotImplementedException();
            
        }

        public T Lire<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
        public Dictionary<string, Utilisateur> ModifierMdp(Dictionary<string, Utilisateur> listeUtilisateur, string Pseudo, string MotDePasse)
        {
            listeUtilisateur.TryGetValue(Pseudo, out Utilisateur a);
            a.Mdp = MotDePasse;
            listeUtilisateur.Remove(Pseudo);
            listeUtilisateur.Add(Pseudo, a);
            return listeUtilisateur;
        }
        public Dictionary<string, Utilisateur> ModifierPseudo(Dictionary<string, Utilisateur> listeUtilisateur, string Pseudo, string Pseudo2)
        {
            listeUtilisateur.TryGetValue(Pseudo, out Utilisateur a);
            a.Pseudo = Pseudo2;
            listeUtilisateur.Remove(Pseudo);
            listeUtilisateur.Add(Pseudo2, a);
            return listeUtilisateur;
        }
        public Dictionary<string, Utilisateur> ModifierDate(Dictionary<string, Utilisateur> listeUtilisateur, string Pseudo, string Date)
        {
            listeUtilisateur.TryGetValue(Pseudo, out Utilisateur a);
            a.Date = Date;
            listeUtilisateur.Remove(Pseudo);
            listeUtilisateur.Add(Pseudo, a);
            return listeUtilisateur;
        }
        public Dictionary<string, Utilisateur> ModifierSexe(Dictionary<string, Utilisateur> listeUtilisateur, string Pseudo, bool Sexe)
        {
            listeUtilisateur.TryGetValue(Pseudo, out Utilisateur a);
            a.Sexe = Sexe;
            listeUtilisateur.Remove(Pseudo);
            listeUtilisateur.Add(Pseudo, a);
            return listeUtilisateur;
        }
        public List<Champion> ModifierNomChamps(string nom, string nom2, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    texte.NomChamps = nom;
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;

        }
        public List<Champion> ModifierHistoireChampion(string nom, string lore, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    texte.Histoire = lore;
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;
        }
        public List<Champion> ModifierVideoChampion(string nom, string videoChamps, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    texte.VideoChamps = videoChamps;
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;
        }
        public List<Champion> ModifierNomSpellChampion(string nom, string nomSort, string nomSort2, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    for (int i = 0; i < 4; ++i)
                    {
                        if (texte.Spell[i].NomSort == nomSort)
                            texte.Spell[i].NomSort = nomSort2;
                    }
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;

        }
        public List<Champion> ModifierDescriptionSpellChampion(string nom, string nomSort, string description, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    for (int i = 0; i < 4; ++i)
                    {
                        if (texte.Spell[i].NomSort == nomSort)
                            texte.Spell[i].Description = description;
                    }
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;
        }
        public List<Champion> ModifierImageSpellChampion(string nom, string nomSort, string image, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    for (int i = 0; i < 4; ++i)
                    {
                        if (texte.Spell[i].NomSort == nomSort)
                            texte.Spell[i].Image = image;
                    }
                    listeChamp.Add(texte);
                }
            }
            
            
            return listeChamp;
        }
        public List<Champion> ModifierTypeSpellChampion(string nom, string nomSort, TypeSpell type, List<Champion> listeChamp)
        {
            foreach (Champion texte in listeChamp.ToList())
            {
                if (texte.NomChamps == nom)
                {
                    listeChamp.Remove(texte);
                    for (int i = 0; i < 4; ++i)
                    {
                        if (texte.Spell[i].NomSort == nomSort)
                            texte.Spell[i].Type = type;
                        
                    }
                    listeChamp.Add(texte);
                }
            }
            return listeChamp;
        }
        public List<Champion> AjouterChampion(List<Champion> listeChamp, string nomchamps, string histoire, string NomSort1, string Description1, string Image1, TypeSpell Type1, string NomSort2, string Description2, string Image2, TypeSpell Type2, string NomSort3, string Description3, string Image3, TypeSpell Type3, string NomSort4, string Description4, string Image4, TypeSpell Type4, string videoChamps, string ImageChamp)
        {
            int i =this.RechercherChampion(nomchamps, listeChamp);
            if (i < 0)
            {

                Console.WriteLine("*88888888888888888");
                Console.WriteLine(nomchamps);
                Console.WriteLine("8888888888888888888888");
               
                
                listeChamp.Add(new Champion(nomchamps, histoire, FaireTableauxDesSort(NomSort1, Description1, Image1, Type1, NomSort2, Description2, Image2, Type2, NomSort3, Description3, Image3, Type3, NomSort4, Description4, Image4, Type4), videoChamps, ImageChamp));
                
            }
                return listeChamp;
        }
        private Sort[] FaireTableauxDesSort(string NomSort1, string Description1, string Image1, TypeSpell Type1, string NomSort2, string Description2, string Image2, TypeSpell Type2, string NomSort3, string Description3, string Image3, TypeSpell Type3, string NomSort4, string Description4, string Image4, TypeSpell Type4)
        {
            
            Sort[] a = new Sort[4];
            #region a[0]
            a[0] = new Sort(NomSort1, Description1, Image1, Type1);
            #endregion
            
            a[1] = new Sort(NomSort2, Description2, Image2, Type2);
            a[2] = new Sort(NomSort3, Description3, Image3, Type3);
            a[3] = new Sort(NomSort4, Description4, Image4, Type4);
            
            return a;
        }
        public List<Champion> RemoveChamp(string nomChamp, List<Champion> listeChamp)
        {
            int i = this.RechercherChampion(nomChamp, listeChamp);
            if (i >= 0)
            {
                listeChamp.Remove(listeChamp[i]);
            }
            return listeChamp;
        }
        public Dictionary<string, Utilisateur> AjouterUtilisateur(Dictionary<string, Utilisateur> listeUtilisateur, string Pseudo, bool Sexe, string Date, string Mdp)
        {
            listeUtilisateur.Add(Pseudo, new Utilisateur(Pseudo, Sexe, Date, Mdp));
            return listeUtilisateur;
        }
        public Dictionary<string, Utilisateur> SupprimerUtilisateur(string Pseudo, Dictionary<string, Utilisateur> listeUtilisateur)
        {
            listeUtilisateur.Remove(Pseudo);
            return listeUtilisateur;
        }

        public int RechercherChampion(string nomChamp, List<Champion> listeChamp)
        {
            int i = 0;
            int nb = 0;
            Console.WriteLine("NomChampion : ");
            for (i =0;i < listeChamp.Count();i++)
            {
               
                Console.WriteLine(nomChamp + "--->" + listeChamp[0].NomChamps);
                if (listeChamp[i].NomChamps == nomChamp)
                {
                    
                    
                    return nb;
                }
                nb = nb + 1;

            }
            
            return -1;
        
        }
        
    }

}
