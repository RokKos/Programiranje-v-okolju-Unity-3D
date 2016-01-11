//Author: Rok Kos
//Date: 05.12.2015
//Description: Class for classroms

using UnityEngine;
using System.Collections;

public class Sola : MonoBehaviour {

	public class Ucilnica{
		/*
		 * To je class v katerem bomo definirali pozicijo vsake ucilnice,
		 * ime ucilnice, nfc tag ucilnice.
		*/
		public Vector3 pozicija;
		public Quaternion rotacija;
		public string ime_Ucilnice;
		public int NFC_tag;

		//Construktor, to so default vresnosti
		public Ucilnica(){

			pozicija =  new Vector3(0f,0f,0f);
			rotacija = new Quaternion(0f,0f,0f,0f);
			ime_Ucilnice = "UNKNOWN";
			NFC_tag = -1;
		}
		//Construktor z vsem
		public Ucilnica(Vector3 vnesena_pozicija,Quaternion vnesena_rotacija,
			string vneseno_ime_Ucilnica, int vnesen_NFC_tag){
			pozicija = vnesena_pozicija;
			rotacija = vnesena_rotacija;
			ime_Ucilnice = vneseno_ime_Ucilnica;
			NFC_tag = vnesen_NFC_tag;
		}
		//Construktor brez rotacije
		public Ucilnica(Vector3 vnesena_pozicija,
			string vneseno_ime_Ucilnica,
			int vnesen_NFC_tag){
			pozicija = vnesena_pozicija;
			rotacija = new Quaternion(0f,0f,0f,0f);
			ime_Ucilnice = vneseno_ime_Ucilnica;
			NFC_tag = vnesen_NFC_tag;
		}

		public Vector3 vrni_pozicijo(){
			return pozicija;
		}

		public Quaternion vrni_rotacijo(){
			return rotacija;
		}

		public string vrni_ime(){
			return ime_Ucilnice;
		}

		public string vrni_class(){
			return ime_Ucilnice + pozicija.ToString ("G4") + "\n";
		}
		//Destructor
		~Ucilnica(){

		}
	}
}