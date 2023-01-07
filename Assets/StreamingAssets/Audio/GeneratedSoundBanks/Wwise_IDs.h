/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID PLAY_ALIEN_STAFF_ATTACK = 2329713267U;
        static const AkUniqueID PLAY_BOXES_BREAK = 1880847345U;
        static const AkUniqueID PLAY_ELLEN_FOOTSTEP = 2458421299U;
        static const AkUniqueID PLAY_SFX_ALIEN_STAFF_IDLE_LOOP = 2476186902U;
        static const AkUniqueID PLAY_SFX_ALIEN_STAFF_PICKUP = 1472032783U;
        static const AkUniqueID PLAY_SFX_CRSYTAL_SWITCHES_BEFORE_ACTIVATION = 1141199166U;
        static const AkUniqueID PLAY_SFX_CRYSTAL_SWITCH_ACTIVATED = 3532940987U;
        static const AkUniqueID PLAY_SFX_CRYSTAL_SWITCHES_AFERT_ACTIVATION = 411583353U;
        static const AkUniqueID PLAY_SFX_HEALTHBOX_IDLE_01 = 1068397626U;
        static const AkUniqueID PLAY_SFX_HEALTHBOX_IDLE_02 = 1068397625U;
        static const AkUniqueID PLAY_SFX_HEALTHBOX_OPEN_01 = 4120424468U;
        static const AkUniqueID PLAY_SFX_HEALTHBOX_OPEN_02 = 4120424471U;
        static const AkUniqueID PLAY_SFX_PRESSURE_PAD_ACTIVATED = 3673773357U;
        static const AkUniqueID PLAY_SFX_PRESSURE_PAD_IDLE = 2961794190U;
        static const AkUniqueID PLAY_SFX_TELEPORTER_RIFT = 2644163508U;
        static const AkUniqueID PLAY_SFX_TELEPORTER_WALKTHROUGH = 2370542445U;
        static const AkUniqueID PLAY_UI_GAME_PAUSE = 4059508246U;
        static const AkUniqueID PLAY_UI_GAME_QUIT = 3336058037U;
        static const AkUniqueID PLAY_UI_GAME_RESUME = 1899199409U;
        static const AkUniqueID PLAY_UI_GAME_START = 1580643620U;
        static const AkUniqueID PLAY_UI_MENU_CANCEL = 1739779019U;
        static const AkUniqueID PLAY_UI_MENU_MOUSE_OVER = 1926492655U;
        static const AkUniqueID PLAY_UI_MENU_NAVIGATION = 1771101267U;
        static const AkUniqueID PLAY_UI_MENU_SELECTION = 2157261217U;
        static const AkUniqueID PLAY_UI_MENU_VOLUME_SLIDER = 2556697005U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace PAUSE_OFF
        {
            static const AkUniqueID GROUP = 3967028551U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PAUSE_OFF

        namespace PAUSE_ON
        {
            static const AkUniqueID GROUP = 3537680115U;

            namespace STATE
            {
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PAUSE_ON

    } // namespace STATES

    namespace SWITCHES
    {
        namespace LOCO_SWITCH
        {
            static const AkUniqueID GROUP = 496641439U;

            namespace SWITCH
            {
                static const AkUniqueID FORWARD = 1164125444U;
                static const AkUniqueID IDLE = 1874288895U;
                static const AkUniqueID ROLL = 2026920480U;
                static const AkUniqueID RUN = 712161704U;
            } // namespace SWITCH
        } // namespace LOCO_SWITCH

        namespace MATERIAL_SWITCH
        {
            static const AkUniqueID GROUP = 3194777289U;

            namespace SWITCH
            {
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID PUDDLE = 2003927601U;
                static const AkUniqueID STONE = 1216965916U;
            } // namespace SWITCH
        } // namespace MATERIAL_SWITCH

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID MASTER_VOLUME = 4179668880U;
        static const AkUniqueID MUSIC_VOLUME = 1006694123U;
        static const AkUniqueID PREMASTER_VOLUME = 2037612127U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID AMB_PADS_SNBK = 1876570981U;
        static const AkUniqueID AMB_RFX_SNBK = 1279863871U;
        static const AkUniqueID CHOMPER_SNBK = 3037172698U;
        static const AkUniqueID ELLEN_LOCO_SNBK = 3228081768U;
        static const AkUniqueID ELLEN_SFX_SNBK = 2516908676U;
        static const AkUniqueID GRENADIER_SNBK = 1568914985U;
        static const AkUniqueID SFX_SNBK = 833899935U;
        static const AkUniqueID SPITTER_SNBK = 4080968021U;
        static const AkUniqueID UI_SNBK = 776533456U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID BUS_AMB = 17439960U;
        static const AkUniqueID BUS_ELLEN = 2766202208U;
        static const AkUniqueID BUS_ENNEMIES = 1592365332U;
        static const AkUniqueID BUS_MUSIC = 1162281553U;
        static const AkUniqueID BUS_PADS = 3056742518U;
        static const AkUniqueID BUS_PREMASTER = 1116497749U;
        static const AkUniqueID BUS_RFX = 4130663432U;
        static const AkUniqueID BUS_SFX = 3895923845U;
        static const AkUniqueID BUS_UI = 1746463750U;
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
