/*
Copyright 2022 Revenu Québec

Permission is hereby granted, free of charge, to any person obtaining a copy of this
software and associated documentation files (the "Software"), to deal in the Software
without restriction, including without limitation the rights to use, copy, modify,
merge, publish, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;

namespace FO_Framework
{
    internal class ValeursPossibles
    {
        /// <summary>
        /// Valeurs autorisées ou standards pour la Configuration des différents éléments.<br />
        /// Allowed or standard values for the Configuration of the different elements.<br />
        /// <br />
        /// Utilisation<br />
        ///     String UrlTransactions = ValeursPossibles.UrlMEVWEB.Transactions;
        ///
        /// </summary>
        internal static class UrlMEVWEB
        {
            /// <summary>
            /// Adresse web à encoder dans le code QR
            /// Web address to encode in the QR code
            /// </summary>
            internal static String QRCode { get { return "https://qr.mev-web.ca?f="; } }

            /// <summary>
            /// Url de base du MEV-WEB<br />
            /// Basic url of the WEB-SRM<br />
            /// </summary>
            private static String UrlBaseMEVWEB { get { return "https://cnfr.api.rq-fo.ca"; } }

            /// <summary>
            /// Url pour l'obtention des certificats du SEV et du MEV-WEB<br />
            /// Url for obtaining SRS/POS and WEB-SRM certificates
            /// </summary>
            internal static String Enrolement { get { return "https://certificats.cnfr.api.rq-fo.ca/enrolement"; } }

            /// <summary>
            /// Url pour ajouter/supprimer ou remplacer un certificat du SEV au MEV-WEB<br />
            /// Url to add/remove or replace an SEV certificate to WEB-SRM
            /// </summary>
            internal static String Certificats { get { return UrlBaseMEVWEB + "/certificats"; } }

            /// <summary>
            /// Url pour ajouter/supprimer ou valider un utilisateur au MEV-WEB<br />
            /// Url to add/remove or validate a user to WEB-SRM
            /// </summary>
            internal static String Utilisateurs { get { return UrlBaseMEVWEB + "/utilisateur"; } }

            /// <summary>
            /// Url pour transmettre une transaction au MEV-WEB<br />
            /// Url to transmit a transaction to WEB-SRM
            /// </summary>
            internal static String Transactions { get { return UrlBaseMEVWEB + "/transaction"; } }

            /// <summary>
            /// Url pour transmettre divers documents au MEV-WEB<br />
            /// Url to transmit various documents to the WEB-SRM
            /// </summary>
            internal static String Document { get { return UrlBaseMEVWEB + "/document"; } }

        }

        /// <summary>
        /// Le champ identifiant le secteur d’activité de l’entreprise.<br />
        /// Abbreviation of the business’s sector of activity.<br />
        /// <br />
        /// Utilisation<br />
        ///     String abrvt = ValeursPossibles.Abrvt.TRP;<br />
        ///
        /// </summary>
        internal static class Abrvt
        {
            /// <summary>
            /// Transport rémunéré de personnes<br />
            /// Remunerated passenger transportation
            /// </summary>
            internal static String TRP { get { return "TRP"; } }

            /// <summary>
            /// Restaurants, bars et camions de restauration<br />
            /// Restaurants, bars and food trucks
            /// </summary>
            internal static String RBC { get { return "RBC"; } }
        }

        /// <summary>
        /// Le champ identifiant le secteur d’activité de l’entreprise.<br />
        /// Field identifying the business's sector of activity<br />
        /// <br />
        /// Utilisation<br />
        ///     String acti = ValeursPossibles.Acti.TRP;
        ///
        /// </summary>
        internal static class Acti
        {
            /// <summary>
            /// Transport rémunéré de personnes<br />
            /// Remunerated passenger transportation
            /// </summary>
            internal static String TRP { get { return "TRP"; } }

            /// <summary>
            /// Restaurant
            /// </summary>
            internal static String RES { get { return "RES"; } }

            /// <summary>
            /// Bar
            /// </summary>
            internal static String BAR { get { return "BAR"; } }

            /// <summary>
            /// Camion de restauration<br />
            /// Food Truck
            /// </summary>
            internal static String CDR { get { return "CDR"; } }

            /// <summary>
            /// Tiers habituel<br />
            /// Usual third party
            /// </summary>
            internal static String HAB { get { return "HAB"; } }

            /// <summary>
            /// Secteur d’activité non visé par les mesures<br />
            /// Sector of activity not covered by the measures
            /// </summary>
            internal static String NON { get { return "NON"; } }

            /// <summary>
            /// Sans Objet<br />
            /// N/A
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }

        /// <summary>
        /// Type d'appareil qui a initié la requête<br />
        /// Type of device that initiated the request<br />
        /// <br />
        /// Utilisation<br />
        ///    String envr = ValeursPossibles.ApprlInit.SEV;
        ///    
        /// </summary>
        internal static class ApprlInit
        {
            /// <summary>
            /// Système d'enregistrement des ventes<br />
            /// Point of Sales System
            /// </summary>
            internal static String SEV { get { return "SEV"; } }

            /// <summary>
            /// Serveur<br />
            /// Server
            /// </summary>
            internal static String SRV { get { return "SRV"; } }
        }

        /// <summary>
        /// Environnement visé pour la requête<br />
        /// Environment used to make the request<br />
        /// <br />
        /// Utilisation<br />
        ///    String envr = ValeursPossibles.Envirn.DEV;
        ///    
        /// </summary>
        internal static class Envirn
        {
            /// <summary>
            /// Développement<br />
            /// Development
            /// </summary>
            internal static String DEV { get { return "DEV"; } }

            /// <summary>
            /// Cas d'essais (Certification)<br />
            /// Test cases
            /// </summary>
            internal static String ESSAI { get { return "ESSAI"; } }

            /// <summary>
            /// Production
            /// </summary>
            internal static String PROD { get { return "PROD"; } }
        }

        /// <summary>
        /// Le type de support d’impression du document.<br />
        /// Document print option<br />
        ///<br />
        /// Utilisation<br />
        ///     String formImpr = ValeursPossibles.FormImpr.PAP;
        ///
        /// </summary>
        internal static class FormImpr
        {
            /// <summary>
            /// Papier<br />
            /// Paper
            /// </summary>
            internal static String PAP { get { return "PAP"; } }

            /// <summary>
            /// Électronique<br />
            /// Electronic
            /// </summary>
            internal static String ELE { get { return "ELE"; } }

            /// <summary>
            /// Papier et électronique<br />
            /// Combined paper and electronic
            /// </summary>
            internal static String PEL { get { return "PEL"; } }

            /// <summary>
            /// Non imprimé<br />
            /// Not printed
            /// </summary>
            internal static String NON { get { return "NON"; } }

            /// <summary>
            /// Sans objet<br />
            /// N/A
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }

        /// <summary>
        /// Le champ indiquant si la modification concerne l’ajout, la suppression ou la validation des numéros d’inscription aux fichiers de la TPS et de la TVQ attribués au mandataire.<br />
        /// Field indicating whether the change concerns the addition, deletion or replacement of a certificate or a user<br />
        /// <br />
        /// Utilisation<br />
        ///     String modif = ValeursPossibles.Modif.AJO;
        ///
        /// </summary>
        internal static class Modif
        {
            /// <summary>
            /// Ajout d'un certificat ou d'un utilisateur<br />
            /// Addition of a certificate or a user
            /// </summary>
            internal static String AJO { get { return "AJO"; } }

            /// <summary>
            /// Remplacement d'un certificat<br />
            /// Remplacement of a certificate or a user
            /// </summary>
            internal static String REM { get { return "REM"; } }

            /// <summary>
            /// Suppression d'un certificat ou d'un utilisateur<br />
            /// Deletion of a certificate or a user
            /// </summary>
            internal static String SUP { get { return "SUP"; } }

            /// <summary>
            /// Validation d'un utilisateur<br />
            /// Validation of a user
            /// </summary>
            internal static String VAL { get { return "VAL"; } }
        };

        /// <summary>
        /// Le mode d’impression du document<br />
        /// Print mode for the document.<br />
        ///<br />
        /// Utilisation<br />
        ///     String modImpr = ValeursPossibles.ModImpr.FAC;
        ///
        /// </summary>
        internal static class ModImpr
        {
            /// <summary>
            /// Annulation<br />
            /// Cancellation
            /// </summary>
            internal static String ANN { get { return "ANN"; } }

            /// <summary>
            /// Reproduction<br />
            /// Reproduction
            /// </summary>
            internal static String RPR { get { return "RPR"; } }

            /// <summary>
            /// Duplicata<br />
            /// Duplicate
            /// </summary>
            internal static String DUP { get { return "DUP"; } }

            /// <summary>
            /// Parti sans payer<br />
            /// Failure to pay
            /// </summary>
            internal static String PSP { get { return "PSP"; } }

            /// <summary>
            /// Facture ou tout autre document non inclus dans cette liste<br />
            /// Bill or any other document not included in this list
            /// </summary>
            internal static String FAC { get { return "FAC"; } }

            /// <summary>
            /// Sans objet<br />
            /// N/A
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }

        /// <summary>
        /// Le mode de paiement utilisé pour acquitter la facture.<br />
        /// Method of payment used for the bill.<br />
        ///<br />
        /// Utilisation<br />
        ///     String modPai = ValeursPossibles.ModPai.ARG;
        ///
        /// </summary>
        internal static class ModPai
        {
            /// <summary>
            /// Argent comptant<br />
            /// Cash
            /// </summary>
            internal static String ARG { get { return "ARG"; } }

            /// <summary>
            /// Chèque<br />
            /// Cheque
            /// </summary>
            internal static String CHQ { get { return "CHQ"; } }

            /// <summary>
            /// Coupon<br />
            /// Coupon
            /// </summary>
            internal static String COU { get { return "COU"; } }

            /// <summary>
            /// Carte de crédit<br />
            /// Credit card
            /// </summary>
            internal static String CRE { get { return "CRE"; } }

            /// <summary>
            /// Carte de débit<br />
            /// Debit card
            /// </summary>
            internal static String DEB { get { return "DEB"; } }

            /// <summary>
            /// Certificat-cadeau (p.ex., carte prépayée, chèque-cadeau)<br />
            /// Prepaid card or Gift card
            /// </summary>
            internal static String CPR { get { return "CPR"; } }

            /// <summary>
            /// Programme de fidélisation<br />
            /// Loyalty program
            /// </summary>
            internal static String FID { get { return "FID"; } }

            /// <summary>
            /// Cryptomonnaie (Bitcoins, ...)<br />
            /// Cryptocurrency (Bitcoins, ...)
            /// </summary>
            internal static String CRY { get { return "CRY"; } }

            /// <summary>
            /// Portefeuille électronique (PayPal, ...)<br />
            /// Digital wallet (PayPal, ...)
            /// </summary>
            internal static String MVO { get { return "MVO"; } }

            /// <summary>
            /// Transfert de fonds<br />
            /// transfer of funds
            /// </summary>
            internal static String TFD { get { return "TFD"; } }

            /// <summary>
            /// Paiement mixte<br />
            /// Mixed payment
            /// </summary>
            internal static String MIX { get { return "MIX"; } }

            /// <summary>
            /// Porté au compte<br />
            /// Charge to account
            /// </summary>
            internal static String PAC { get { return "PAC"; } }

            /// <summary>
            /// Autre<br />
            /// other
            /// </summary>
            internal static String AUT { get { return "AUT"; } }

            /// <summary>
            /// Inconnu<br />
            /// Unknown
            /// </summary>
            internal static String INC { get { return "INC"; } }

            /// <summary>
            /// Aucun paiement<br />
            /// No payment
            /// </summary>
            internal static String AUC { get { return "AUC"; } }

            /// <summary>
            /// Sans objet<br />
            /// N/A
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }

        /// <summary>
        /// Le mode de transaction utilisé<br />
        /// Transaction mode used<br />
        ///<br />
        /// Utilisation<br />
        ///     String modTrans = ValeursPossibles.ModTrans.OPE;
        ///
        /// </summary>
        internal static class ModTrans
        {
            /// <summary>
            /// Opérationnel<br />
            /// Operation
            /// </summary>
            internal static String OPE { get { return "OPE"; } }

            /// <summary>
            /// Formation<br />
            /// Training
            /// </summary>
            internal static String FOR { get { return "FOR"; } }
        }

        /// <summary>
        /// Le type de relation d’affaires.<br />
        /// The type of business relationship.<br />
        ///<br />
        /// Utilisation<br />
        ///     String RelaCommer = ValeursPossibles.RelaCommer.B2C;
        ///
        /// </summary>
        internal static class RelaCommer
        {
            /// <summary>
            /// Entreprise à entreprise<br />
            /// Business to business
            /// </summary>
            internal static String B2B { get { return "B2B"; } }

            /// <summary>
            /// Entreprise à consommateur<br />
            /// Business to consumer
            /// </summary>
            internal static String B2C { get { return "B2C"; } }

            /// <summary>
            /// Entreprise à gouvernement<br />
            /// business to government
            /// </summary>
            internal static String B2G { get { return "B2G"; } }
        }

        /// <summary>
        /// Un indicateur que la taxe s’applique pour la fourniture payée ou payable.<br />
        /// Indicator that tax applies to each supply paid or payable.<br />
        ///<br />
        /// Utilisation<br />
        ///     String tax = ValeursPossibles.Tax.FP;
        ///
        /// </summary>
        internal static class Tax
        {
            /// <summary>
            /// Fédérale (TPS)<br />
            /// Federal (GST)
            /// </summary>
            internal static String F { get { return "F"; } }

            /// <summary>
            /// Provinciale (TVQ)<br />
            /// Provincial (QST)
            /// </summary>
            internal static String P { get { return "P"; } }

            /// <summary>
            /// Fédérale et provinciale (TPS et TVQ)<br />
            /// Federal and provincial (GST and QST)
            /// </summary>
            internal static String FP { get { return "FP"; } }

            /// <summary>
            /// Non taxable<br />
            /// Non-taxable
            /// </summary>
            internal static String NON { get { return "NON"; } }

            /// <summary>
            /// Sans objet<br />
            /// N/A
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }

        /// <summary>
        /// Le type d’adresse du client<br />
        /// Customer’s address type<br />
        /// <br />
        /// Utilisation<br />
        ///     String typAdr = ValeursPossibles.TypAdr.LVR;
        /// 
        /// </summary>
        internal static class TypAdr
        {
            /// <summary>
            /// Domicile<br />
            /// Residence
            /// </summary>
            internal static String DOM { get { return "DOM"; } }

            /// <summary>
            /// Facturation<br />
            /// Billing
            /// </summary>
            internal static String FAC { get { return "FAC"; } }

            /// <summary>
            /// Livraison<br />
            /// Delivery
            /// </summary>
            internal static String LVR { get { return "LVR"; } }

            /// <summary>
            /// Service rendu<br />
            /// Service provided
            /// </summary>
            internal static String SRV { get { return "SRV"; } }
        }

        /// <summary>
        /// Le champ identifiant le type de document transmis.<br />
        /// Field identifying the type of document sent.<br />
        /// <br />
        /// Utilisation<br />
        ///     String typServ = ValeursPossibles.TypDoc.RUT;
        /// 
        /// </summary>
        internal static class TypDoc
        {
            /// <summary>
            /// Rapport de l’utilisateur<br />
            /// User report
            /// </summary>
            internal static String RUT { get { return "RUT"; } }

            /// <summary>
            /// Tiers habituel<br />
            /// Usual third party
            /// </summary>
            internal static String HAB { get { return "HAB"; } }
        }

        /// <summary>
        /// Type de service<br />
        /// Service types<br />
        /// <br />
        /// Utilisation<br />
        ///     String typServ = ValeursPossibles.TypServ.LVR;
        /// </summary>
        internal static class TypServ
        {
            /// <summary>
            /// Mode comptoir<br />
            /// Counter service
            /// </summary>
            internal static String CMP { get { return "CMP"; } }

            /// <summary>
            /// Livraison par le mandataire<br />
            /// Restaurant delivery
            /// </summary>
            internal static String LVR { get { return "LVR"; } }

            /// <summary>
            /// livraison par une plateforme électronique<br />
            /// Electronic platform delivery
            /// </summary>
            internal static String LVT { get { return "LVT"; } }

            /// <summary>
            /// Service aux tables<br />
            /// Table service
            /// </summary>
            internal static String TBL { get { return "TBL"; } }
        }

        /// <summary>
        /// Le type de transaction<br />
        /// Transaction type<br />
        ///<br />
        /// Utilisation<br />
        ///     String typTrans = ValeursPossibles.TypTrans.ADDI;
        ///
        /// </summary>
        internal static class TypTrans
        {
            /// <summary>
            /// Le type de transaction : Addition<br />
            /// Transaction type : Temporary bill
            /// </summary>
            internal static String ADDI { get { return "ADDI"; } }

            /// <summary>
            /// Le type de transaction : Estimation<br />
            /// Transaction type : Estimate
            /// </summary>
            internal static String ESTM { get { return "ESTM"; } }

            /// <summary>
            /// Le type de transaction : Reçu de fermeture<br />
            /// Transaction type : Closing receipt
            /// </summary>
            internal static String RFER { get { return "RFER"; } }

            /// <summary>
            /// Le type de transaction : Soumission<br />
            /// Transaction type : Quote
            /// </summary>
            internal static String SOUM { get { return "SOUM"; } }

            /// <summary>
            /// Le type de transaction : Tiers inhabituel<br />
            /// Transaction type : Occasional third party
            /// </summary>
            internal static String TIER { get { return "TIER"; } }

            /// <summary>
            /// Le type de transaction : Sans objet<br />
            /// Transaction type : n/a
            /// </summary>
            internal static String SOB { get { return "SOB"; } }
        }
        /// <summary>
        /// Champ TS du rapport de l'utilisateur
        /// </summary>
        internal static class TS
        {
            /// <summary>
            /// Si le sommaire des ventes est calculé pour un seul SEV, inscrire "A"<br />
            /// If the sales summary is calculated for a single SRS, enter "A"
            /// </summary>
            internal static String A { get { return "A"; } }

            /// <summary>
            /// Si le sommaire des ventes est calculé pour l'ensemble des SEV de l'établissement, inscrire "E"<br />
            /// If the sales summary is calculated for all the establishment's SRS, enter "E".
            /// </summary>
            internal static String E { get { return "E"; } }
        }

        /// <summary>
        /// Champ CM du rapport de l'utilisateur<br />
        /// </summary>
        internal static class CM
        {
            /// <summary>
            /// Si les ventes correspondent à un seul utilisateur, inscrire "Unique"<br />
            /// If sales correspond to a single user, enter "Unique".
            /// </summary>
            internal static String UNIQUE { get { return "Unique"; } }

            /// <summary>
            /// Si les ventes correspondent à tous les utilisateurs de l'établissement, inscrire "Tous"<br />
            /// If sales correspond to all users of the establishment, enter "Tous".
            /// </summary>
            internal static String TOUS { get { return "Tous"; } }
        }
    }
}
