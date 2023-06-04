using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

    

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
				
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) {
						case "atkritumi":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[1]); objektuSkripts.nomestasMasinas++;
							break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]); objektuSkripts.nomestasMasinas++;
							break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot( 
								objektuSkripts.skanasKoAtskanot[3]); objektuSkripts.nomestasMasinas++;
							break;

                        case "b2":
                            objektuSkripts.skanasAvots.PlayOneShot(
                            objektuSkripts.skanasKoAtskanot[4]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "cements":
                            objektuSkripts.skanasAvots.PlayOneShot(
                            objektuSkripts.skanasKoAtskanot[5]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "e46":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[6]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "e61":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[7]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "ekskavators":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[8]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "policija":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[9]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "trak1":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[10]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "trak5":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[11]); objektuSkripts.nomestasMasinas++;
                            break;

                        case "ugunsdzeseji":
                            objektuSkripts.skanasAvots.PlayOneShot(objektuSkripts.skanasKoAtskanot[12]); objektuSkripts.nomestasMasinas++;
                            break;

                        default:
							Debug.Log("Tags nav definēts!");
							break;
					}
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord; 

                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;

                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;

					case "b2":
						objektuSkripts.b2.GetComponent<RectTransform>().localPosition = objektuSkripts.b2Koord;
                        break;

					case "cements":
						objektuSkripts.CementaMasina.GetComponent<RectTransform>().localPosition = objektuSkripts.CementaKoord;
                        break;

					case "e46":
						objektuSkripts.e46.GetComponent<RectTransform>().localPosition = objektuSkripts.e46Koord;
                        break;

                    case "e61":
                        objektuSkripts.e61.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.e61Koord;
                        break;

                    case "ekskavators":
                        objektuSkripts.ekskavators.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.ekskavatorsKoord;
                        break;

                    case "policija":
                        objektuSkripts.policija.
                         GetComponent<RectTransform>().localPosition =  
                         objektuSkripts.policijaKoord;
                        break;

                    case "trak1":
                        objektuSkripts.traktors1.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors1Koord;
                        break;

                    case "trak5":
                        objektuSkripts.traktors5.GetComponent<RectTransform>().localPosition = objektuSkripts.traktors5Koord;
                        break;

                    case "ugunsdz":
                        objektuSkripts.ugunsdzesejs.GetComponent<RectTransform>().localPosition = objektuSkripts.ugunsdzesejsKoord;
                        break;

                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}
}
