using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Poker;

public class DemoGUI : MonoBehaviour
{
    private CardDeck nowCardDeck;
    private CardDeck nowHand;

    private void OnGUI()
    {
        Vector3 guiScale = Vector3.one * 2f;
        GUI.matrix = Matrix4x4.TRS( new Vector3(0, 0, 0), Quaternion.identity, guiScale );

        DrawGUI_Button();
        DrawGUI_Info();
    }

    private void DrawGUI_Button()
    {
        // Deck
        if( GUI.Button( new Rect( 0, 0, 150, 50 ), "Create Deck" ) )
        {
            nowCardDeck = new CardDeck();
            nowCardDeck.AddOneSetOfDeck();
            nowCardDeck.Debug_LogNowCards();
        }

        if( GUI.Button( new Rect( 0, 50, 150, 50 ), "Shuffle Deck" ) )
        {
            nowCardDeck?.Shuffle();
            Debug.Log( "Deck Shuffle" );
            nowCardDeck?.Debug_LogNowCards();
        }

        if( GUI.Button( new Rect( 0, 150, 150, 50 ), "Deal 1 To Hand" ) )
        {
            nowCardDeck?.DealCardFromTop( nowHand );
        }

        // Hand
        if( GUI.Button( new Rect( 150, 0, 150, 50 ), "Create Hand" ) )
        {
            nowHand = new CardDeck();
        }
    }

    private void DrawGUI_Info()
    {
        if( nowHand == null )
            return;

        // Hand
        string handInfo = "手牌資訊";
        for( int i = 0; i < nowHand.Cards.Count; i++ )
            handInfo += $"\n{ nowHand.Cards[ i ].CardStrInfo }";
        GUI.Label( new Rect( 450, 0, 150, 800 ), handInfo );

        // Hand Score
        float handScore = 0f;
        string handScoreInfo = $"手牌分數 : { handScore }";
        GUI.Label( new Rect( 650, 0, 150, 800 ), handScoreInfo );
    }
}