S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 18143
Date: 2020-05-31 10:44:37+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 18143, uid 5000)

Register Information
r0   = 0x44513068, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x414c128a, r5   = 0xbed4ca80
r6   = 0x417bb180, r7   = 0xbed4cb40
r8   = 0x00000000, r9   = 0x4183d9c8
r10  = 0x4183a8e8, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbed4ca80
lr   = 0x414c0f89, pc   = 0x414c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     29052 KB
Buffers:     25144 KB
Cached:     135744 KB
VmPeak:     113768 KB
VmSize:     111732 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20008 KB
VmRSS:       20004 KB
VmData:      46636 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25412 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 18143 TID = 18143
18143 18176 18177 18181 

Maps Information
40000000 40005000 r-xp /usr/bin/launchpad-loader
4000d000 4002a000 r-xp /lib/ld-2.13.so
40033000 40037000 r-xp /usr/lib/libsys-assert.so
40041000 40047000 r-xp /usr/lib/libappcore-efl.so.1.1
40056000 40063000 r-xp /usr/lib/libaul.so.0.1.0
4006d000 4006f000 r-xp /lib/libdl-2.13.so
40078000 4007b000 r-xp /usr/lib/libbundle.so.0.1.22
40083000 40085000 r-xp /usr/lib/libdlog.so.0.0.0
4008d000 400a1000 r-xp /lib/libpthread-2.13.so
400ac000 401e8000 r-xp /usr/lib/libelementary.so.1.7.99
401ff000 402cd000 r-xp /usr/lib/libevas.so.1.7.99
402f3000 4030a000 r-xp /usr/lib/libecore.so.1.7.99
40321000 4037f000 r-xp /usr/lib/libedje.so.1.7.99
40389000 40459000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
4045a000 40460000 r-xp /usr/lib/libprivilege-control.so.0.0.2
40468000 4046c000 r-xp /usr/lib/libsmack.so.1.0.0
40475000 4047d000 r-xp /lib/libgcc_s-4.6.so.1
4047e000 405a2000 r-xp /lib/libc-2.13.so
405b0000 405ce000 r-xp /usr/lib/libsystemd.so.0.4.0
405d8000 405e3000 r-xp /lib/libunwind.so.8.0.1
40610000 40627000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
4062f000 40659000 r-xp /usr/lib/libdbus-1.so.3.8.12
40662000 40667000 r-xp /usr/lib/libxdgmime.so.1.1.0
4066f000 40692000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
4069a000 4069b000 r-xp /usr/lib/libsecurity-extension-interface.so.1.0.1
406a3000 406a9000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
406b2000 4071b000 r-xp /lib/libm-2.13.so
40724000 4073d000 r-xp /usr/lib/libeet.so.1.7.99
4074e000 4078f000 r-xp /usr/lib/libeina.so.1.7.99
40798000 407ba000 r-xp /usr/lib/libecore_evas.so.1.7.99
407c3000 407c8000 r-xp /usr/lib/libecore_file.so.1.7.99
407d0000 407e1000 r-xp /usr/lib/libecore_input.so.1.7.99
407e9000 407f2000 r-xp /usr/lib/libvconf.so.0.2.45
407fa000 4084a000 r-xp /usr/lib/libecore_x.so.1.7.99
4084c000 40855000 r-xp /usr/lib/libedbus.so.1.7.99
4085d000 40877000 r-xp /usr/lib/libecore_con.so.1.7.99
40880000 40893000 r-xp /usr/lib/libfribidi.so.0.3.1
4089b000 408e0000 r-xp /usr/lib/libharfbuzz.so.0.10200.4
408e9000 40911000 r-xp /usr/lib/libfontconfig.so.1.8.0
40912000 40968000 r-xp /usr/lib/libfreetype.so.6.11.3
40974000 409ca000 r-xp /usr/lib/libpixman-1.so.0.28.2
409d7000 409dd000 r-xp /lib/librt-2.13.so
409e6000 409ed000 r-xp /usr/lib/libembryo.so.1.7.99
409f5000 40a0c000 r-xp /usr/lib/liblua-5.1.so
40a15000 40a1b000 r-xp /usr/lib/libecore_imf.so.1.7.99
40a23000 40a24000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
40a2c000 40a5b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
40a63000 40a66000 r-xp /lib/libcap.so.2.21
40a6e000 40a86000 r-xp /usr/lib/liblzma.so.5.0.3
40a8e000 40a9e000 r-xp /lib/libresolv-2.13.so
40aa2000 40b75000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40b80000 40bb4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40bbd000 40bd7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40bdf000 40c54000 r-xp /usr/lib/libsqlite3.so.0.8.6
40c5e000 40c60000 r-xp /usr/lib/libsecurity-extension-common.so.1.0.1
40c68000 40c7e000 r-xp /lib/libz.so.1.2.5
40c86000 40ca9000 r-xp /usr/lib/libjpeg.so.8.0.2
40cc1000 40da2000 r-xp /usr/lib/libX11.so.6.3.0
40dad000 40db2000 r-xp /usr/lib/libecore_fb.so.1.7.99
40dbb000 40dbf000 r-xp /usr/lib/libecore_ipc.so.1.7.99
40dc8000 40dcb000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
40dd3000 40dda000 r-xp /usr/lib/libXcursor.so.1.0.2
40de2000 40de4000 r-xp /usr/lib/libXdamage.so.1.1.0
40dec000 40dee000 r-xp /usr/lib/libXcomposite.so.1.0.0
40df6000 40df8000 r-xp /usr/lib/libXgesture.so.7.0.0
40e00000 40e03000 r-xp /usr/lib/libXfixes.so.3.1.0
40e0b000 40e14000 r-xp /usr/lib/libXi.so.6.1.0
40e1c000 40e1d000 r-xp /usr/lib/libXinerama.so.1.0.0
40e26000 40e2c000 r-xp /usr/lib/libXrandr.so.2.2.0
40e34000 40e3a000 r-xp /usr/lib/libXrender.so.1.3.0
40e42000 40e46000 r-xp /usr/lib/libXtst.so.6.1.0
40e4e000 40e58000 r-xp /usr/lib/libXext.so.6.4.0
40e61000 40ea5000 r-xp /usr/lib/libcurl.so.4.3.0
40eae000 40ec4000 r-xp /lib/libexpat.so.1.6.0
40ece000 40ee6000 r-xp /usr/lib/libpng12.so.0.50.0
40eee000 40f0b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
40f14000 40fa8000 r-xp /usr/lib/libstdc++.so.6.0.16
40fbb000 40fbe000 r-xp /lib/libattr.so.1.1.0
40fc6000 40fc7000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
40fcf000 40fd4000 r-xp /usr/lib/libffi.so.5.0.10
40fdd000 40fdf000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
40fe7000 410b3000 r-xp /usr/lib/libxml2.so.2.7.8
410c0000 410c2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
410cb000 410cd000 r-xp /usr/lib/journal/libjournal.so.0.1.0
410d5000 410e8000 r-xp /usr/lib/libxcb.so.1.1.0
410f2000 410fb000 r-xp /usr/lib/libcares.so.2.1.0
41104000 41132000 r-xp /usr/lib/libidn.so.11.5.44
4113a000 41181000 r-xp /usr/lib/libssl.so.1.0.0
4118d000 4131f000 r-xp /usr/lib/libcrypto.so.1.0.0
41341000 41343000 r-xp /usr/lib/libiri.so
4134b000 41352000 r-xp /lib/libcrypt-2.13.so
41382000 41384000 r-xp /usr/lib/libXau.so.6.0.0
41491000 41495000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4149d000 414a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
414a7000 414ac000 r-xp /usr/lib/libappcore-common.so.1.1
414b4000 414b6000 r-xp /usr/lib/libiniparser.so.0
414bf000 414c2000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
414d5000 414d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
414e2000 414e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
414ed000 414f3000 r-xp /usr/lib/libappsvc.so.0.1.0
414fb000 4151f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41528000 415f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4160d000 41617000 r-xp /lib/libnss_files-2.13.so
418b4000 418bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
418ca000 418d6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
418df000 41900000 r-xp /usr/lib/libefl-extension.so.0.1.0
41908000 41932000 r-xp /usr/lib/libsensor.so.1.9.7
4193b000 41942000 r-xp /usr/lib/libctx-shared.so.0.8.3
4194a000 4194f000 r-xp /usr/lib/libctx-client.so.0.8.3
41957000 41969000 r-xp /usr/lib/libefl-assist.so.0.1.0
41971000 41a29000 r-xp /usr/lib/libcairo.so.2.11200.14
41a34000 41a3e000 r-xp /usr/lib/libsensord-shared.so
41a47000 41a56000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41a5f000 41a75000 r-xp /usr/lib/libtts.so
41a7e000 41aa1000 r-xp /usr/lib/libui-extension.so.0.1.0
41aaa000 41ab5000 r-xp /usr/lib/libtbm.so.1.0.0
41abd000 41acb000 r-xp /usr/lib/libGLESv2.so.2.0
41ad4000 41ad5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41ade000 41ae4000 r-xp /usr/lib/libxcb-render.so.0.0.0
41aec000 41aef000 r-xp /usr/lib/libEGL.so.1.4
41af7000 41afc000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41b04000 41b07000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41b0f000 41b10000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41b19000 41ca1000 r-xp /usr/lib/libicui18n.so.57.1
41cb1000 41db7000 r-xp /usr/lib/libicuuc.so.57.1
41dcd000 41dd5000 r-xp /usr/lib/libdrm.so.2.4.0
41ddd000 41ddf000 r-xp /usr/lib/libdri2.so.0.0.0
41de7000 41ded000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41df5000 41dfa000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41e02000 41e1b000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
436bc000 436dd000 r-xp /usr/lib/libexif.so.12.3.3
436f0000 436f2000 r-xp /usr/lib/libttrace.so.1.1
436fa000 436ff000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43707000 4370d000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43716000 4371e000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43726000 43748000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43751000 43758000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43761000 43763000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4376b000 43772000 r-xp /usr/lib/libminizip.so.1.0.0
4377a000 43787000 r-xp /usr/lib/libail.so.0.1.0
43790000 43796000 r-xp /usr/lib/libproc-stat.so.0.2.96
4379e000 4379f000 r-xp /usr/lib/libresponse.so.0.2.96
437a7000 437ac000 r-xp /usr/lib/libsystem.so.0.0.0
437b6000 43880000 r-xp /usr/lib/libCOREGL.so.4.0
43bf1000 43bfc000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c05000 43c0a000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c12000 43c29000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c36000 43c38000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
444d8000 444d9000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
444e1000 444e4000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
444ec000 444ed000 r-xp /usr/lib/evas/modules/savers/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
444f7000 444f8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
4482c000 4502b000 rw-p [stack:18176]
4502c000 4582b000 rw-p [stack:18177]
4602c000 4682b000 rw-p [stack:18181]
468aa000 468b2000 r-xp /usr/lib/libfeedback.so.0.1.4
468b4000 468b6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
468be000 468c9000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
468d1000 468d8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
468e0000 468f8000 r-xp /usr/lib/libmmfsound.so.0.1.0
46909000 4690d000 r-xp /usr/lib/libmmfsession.so.0.0.0
46916000 46921000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
4692e000 46932000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
4693a000 46950000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46958000 469b9000 r-xp /usr/lib/libasound.so.2.0.0
469c3000 469c6000 r-xp /usr/lib/libpulse-simple.so.0.0.4
469ce000 46a06000 r-xp /usr/lib/libpulse.so.0.16.2
46a07000 46a0a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46a12000 46a5b000 r-xp /usr/lib/libmdm.so.1.2.70
46a64000 46a67000 r-xp /usr/lib/libtinycompress.so.0.0.0
46a6f000 46a74000 r-xp /usr/lib/libjson.so.0.0.1
46a7c000 46ac5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46ace000 46b15000 r-xp /usr/lib/libsndfile.so.1.0.26
46b21000 46b31000 r-xp /usr/lib/libmdm-common.so.1.1.25
46b39000 46b5b000 r-xp /usr/lib/libvorbis.so.0.4.3
46b63000 46b67000 r-xp /usr/lib/libogg.so.0.7.1
bed40000 bee38000 rw-p [stack]
End of Maps Information

Callstack Information (PID:18143)
Call Stack Count: 18
 0: save_data + 0x7d (0x414c0f8a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1f8a
 1: _button_click_cb + 0x148 (0x414c0c51) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1c51
 2: evas_object_smart_callback_call + 0x88 (0x402345cd) [/usr/lib/libevas.so.1] + 0x355cd
 3: (0x40366f0d) [/usr/lib/libedje.so.1] + 0x45f0d
 4: (0x4036aefd) [/usr/lib/libedje.so.1] + 0x49efd
 5: (0x40367869) [/usr/lib/libedje.so.1] + 0x46869
 6: (0x40367c1b) [/usr/lib/libedje.so.1] + 0x46c1b
 7: (0x40367d55) [/usr/lib/libedje.so.1] + 0x46d55
 8: (0x402fe3f5) [/usr/lib/libecore.so.1] + 0xb3f5
 9: (0x402fbe53) [/usr/lib/libecore.so.1] + 0x8e53
10: (0x402ff46b) [/usr/lib/libecore.so.1] + 0xc46b
11: ecore_main_loop_begin + 0x30 (0x402ff879) [/usr/lib/libecore.so.1] + 0xc879
12: appcore_efl_main + 0x332 (0x40044b47) [/usr/lib/libappcore-efl.so.1] + 0x3b47
13: ui_app_main + 0xb0 (0x41493421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x12e (0x414c0477) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1477
15: register_gyroscope_callback + 0x1e (0x40001a53) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1a53
16: __libc_start_main + 0x114 (0x4049585c) [/lib/libc.so.6] + 0x1785c
17: accelerometer_cb + 0x137 (0x40001e0c) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1e0c
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
age_update(678) > [wnidicator_moment_view_battery_image_update:678] [CHARGING_UI] battery level 47, index 9, bg level 45
05-31 10:44:23.705+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(765) > [wnidicator_moment_view_battery_image_update:765] [CHARGING_UI] strLevel : 47, 47
05-31 10:44:23.705+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(774) > [wnidicator_moment_view_battery_image_update:774] [CHARGING_UI] Succeed to get icu str for battery_level, so set (47)
05-31 10:44:23.705+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(788) > [wnidicator_moment_view_battery_image_update:788] [Normal or Arabic] current_locale : vi_VN.UTF-8
05-31 10:44:24.285+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:24.285+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:24.285+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:24.285+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:24.285+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:24.285+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:24.285+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:24.285+0700 W/W_HOME  (  970): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 10:44:24.285+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : 1127407240[0;m
05-31 10:44:24.285+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
05-31 10:44:24.285+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 10:44:24.285+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-31 10:44:24.295+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 10:44:24.300+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-31 10:44:24.305+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-31 10:44:24.305+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-31 10:44:24.310+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 10:44:24.315+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 10:44:24.315+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 10:44:24.315+0700 I/HIGEAR  ( 1186): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-31 10:44:24.450+0700 W/W_INDICATOR(  713): windicator_moment_view.c: _fade_in_battery_layout(1494) > [_fade_in_battery_layout:1494] [CHARGING_UI][Rotation status] _fade_in_battery_layout
05-31 10:44:24.450+0700 E/W_INDICATOR(  713): windicator_moment_view.c: _fade_in_battery_layout(1497) > [_fade_in_battery_layout:1497] [CHARGING_UI][Rotation status] Battery layout is already shown by rotation callback
05-31 10:44:25.465+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:25.465+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:25.465+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:25.465+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:25.465+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:25.465+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:25.465+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:25.505+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-31 10:44:25.520+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
05-31 10:44:25.520+0700 W/W_HOME  (  970): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 10:44:25.520+0700 W/W_HOME  (  970): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-31 10:44:25.520+0700 W/W_HOME  (  970): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-31 10:44:25.520+0700 W/W_HOME  (  970): gesture.c: _manual_render_enable(138) > 1
05-31 10:44:25.520+0700 W/W_HOME  (  970): event_manager.c: _lcd_off_cb(723) > lcd state: 0
05-31 10:44:25.520+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 10:44:25.520+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-31 10:44:25.520+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 10:44:25.525+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-31 10:44:25.525+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1284) > [_on_lcd_signal_receive_cb:1284] _on_lcd_signal_receive_cb, 1284, Pre LCD off by [gesture]
05-31 10:44:25.525+0700 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1089) > [_pre_lcd_off:1089] Will LCD OFF as wake_up_setting[1]
05-31 10:44:25.525+0700 E/STARTER (  711): scontext_util.c: sconstext_util_check_lock_type(47) > [sconstext_util_check_lock_type:47] current lock state :[0],testmode[0]
05-31 10:44:25.525+0700 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(72) > [scontext_util_handle_lock_state:72] wear state[0],bPossible [0],usage [0]
05-31 10:44:25.525+0700 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(211) > [_check_reserved_popup_status:211] Current reserved apps status : 0
05-31 10:44:25.525+0700 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(247) > [_check_reserved_apps_status:247] Current reserved apps status : 0
05-31 10:44:25.530+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-31 10:44:25.530+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-31 10:44:25.550+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 10:44:25.550+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 10:44:25.550+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 10:44:25.550+0700 I/HIGEAR  ( 1186): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-31 10:44:25.655+0700 W/SHealthCommon( 1277): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:3[0;m
05-31 10:44:25.655+0700 W/SHealthServiceCommon( 1277): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
05-31 10:44:25.665+0700 W/W_INDICATOR(  713): windicator_util.c: _pm_state_changed_cb(920) > [_pm_state_changed_cb:920] LCD off
05-31 10:44:25.665+0700 W/W_INDICATOR(  713): windicator_connection.c: windicator_connection_pause(2268) > [windicator_connection_pause:2268] 
05-31 10:44:25.665+0700 E/W_INDICATOR(  713): windicator_connection.c: windicator_connection_pause(2287) > [windicator_connection_pause:2287] There is no handle
05-31 10:44:25.670+0700 W/SHealthCommon(13558): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:3[0;m
05-31 10:44:25.705+0700 W/W_INDICATOR(  713): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
05-31 10:44:25.710+0700 W/W_INDICATOR(  713): windicator_moment_view.c: _battery_disp_timer_cb(1240) > [_battery_disp_timer_cb:1240] [CHARGING_UI] _battery_disp_timer_cb
05-31 10:44:25.710+0700 W/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_hide_directly(1685) > [windicator_moment_view_hide_directly:1685] windicator_moment_view_hide_directly [1]
05-31 10:44:25.735+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1297) > [_on_lcd_signal_receive_cb:1297] _on_lcd_signal_receive_cb, 1297, Post LCD off by [gesture]
05-31 10:44:25.740+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1190) > [_post_lcd_off:1190] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 10:44:25.740+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1197) > [_post_lcd_off:1197] Current reserved apps status : 0
05-31 10:44:25.745+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1215) > [_post_lcd_off:1215] raise homescreen after 20 sec. home_visible[0]
05-31 10:44:25.745+0700 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(31-5-2020, 10:44:46), repeat(1), interval(20), type(-1073741822)
05-31 10:44:25.750+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [711].
05-31 10:44:25.795+0700 I/APP_CORE(18143): appcore-efl.c: __do_app(453) > [APP 18143] Event: PAUSE State: RUNNING
05-31 10:44:25.795+0700 I/CAPI_APPFW_APPLICATION(18143): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 10:44:25.795+0700 W/APP_CORE(18143): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[2e00002] -> redirected win[6029d4] for org.example.basicui[18143]
05-31 10:44:25.810+0700 E/ALARM_MANAGER(  513): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 880849126, next duetime: 1590896686
05-31 10:44:25.810+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(880849126)
05-31 10:44:25.810+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1590939272), due_time(1590896686)
05-31 10:44:25.820+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
05-31 10:44:25.825+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 10:44:25.825+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 31-5-2020, 03:44:46 (UTC).
05-31 10:44:25.825+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 10:44:25.825+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 10:44:25.835+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
05-31 10:44:25.840+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 10:44:25.845+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: PAUSE State: RUNNING
05-31 10:44:25.845+0700 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 10:44:25.855+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(615) > [_windicator_dbus_lcd_off_completed_cb:615] LCD Off completed signal is received
05-31 10:44:25.855+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(620) > [_windicator_dbus_lcd_off_completed_cb:620] Moment bar status -> idle. (Hide Moment bar)
05-31 10:44:25.855+0700 W/W_INDICATOR(  713): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
05-31 10:44:25.925+0700 W/W_INDICATOR(  713): windicator_moment_view.c: _charging_ui_fade_out_end_cb(595) > [_charging_ui_fade_out_end_cb:595] Fade out end. Call moment_view_hide
05-31 10:44:25.925+0700 E/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_hide(1634) > [windicator_moment_view_hide:1634] Hide Moment View , Type(1)
05-31 10:44:25.930+0700 W/W_INDICATOR(  713): windicator_util.c: windicator_util_back_key_ungrab(879) > [windicator_util_back_key_ungrab:879] Ref count [1].
05-31 10:44:26.005+0700 W/APP_CORE(  713): appcore-efl.c: __hide_cb(882) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-31 10:44:26.005+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: PAUSE State: PAUSED
05-31 10:44:27.710+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:27.710+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:27.730+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:27.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:27.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:27.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:27.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:27.765+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 2 to 1 
05-31 10:44:27.765+0700 E/wnoti-service(  878): wnoti-native-client.c: handle_cache_notification(790) > >>
05-31 10:44:27.775+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 2 -> 1
05-31 10:44:27.780+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
05-31 10:44:27.780+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:44:29.980+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
05-31 10:44:30.095+0700 W/SHealthServiceCommon( 1277): StepLevelSensorProxy.cpp: StepLevelMonitorUpdated(374) > [1;40;33mOnNotWearingStop[0;m
05-31 10:44:30.095+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [4880][0;m
05-31 10:44:30.195+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:30.210+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:30.230+0700 W/SHealthCommon( 1277): TimelineSessionStorage.cpp: OnTriggered(1290) > [1;40;33mlocalStartTime: 1590883200000,000000[0;m
05-31 10:44:30.265+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.270+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:30.320+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.320+0700 W/SHealthServiceCommon( 1277): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1590858000000,000000, end 1590896670321,000000, calories 734,969653[0;m
05-31 10:44:30.320+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.320+0700 W/SHealthCommon( 1277): TimelineSessionStorage.cpp: OnTriggered(1290) > [1;40;33mlocalStartTime: 1590883200000,000000[0;m
05-31 10:44:30.350+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.355+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.355+0700 W/SHealthServiceCommon( 1277): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1590858000000,000000, end 1590896670356,000000, calories 734,971251[0;m
05-31 10:44:30.355+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:30.800+0700 I/APP_CORE(18143): appcore-efl.c: __do_app(453) > [APP 18143] Event: MEM_FLUSH State: PAUSED
05-31 10:44:30.860+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: MEM_FLUSH State: PAUSED
05-31 10:44:32.740+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:32.740+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:32.750+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:32.750+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:32.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:32.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:32.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:32.805+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 1 to 2 
05-31 10:44:32.825+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 1 -> 2
05-31 10:44:32.840+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
05-31 10:44:32.840+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:44:36.605+0700 W/SHealthCommon(13558): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
05-31 10:44:36.645+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:44:36.695+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOn
05-31 10:44:36.695+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_lcd_status_handler(1250) > Call the time_tick_cb
05-31 10:44:36.695+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:36.695+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:36.695+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:36.695+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:36.695+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:36.700+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_lcd_status_handler(1257) > Call widget_provider_update_event
05-31 10:44:36.710+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:44:36.715+0700 W/wnotibp ( 4503): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(93) > ::APP:: view state=0, 2, 0
05-31 10:44:36.715+0700 I/wnotibp ( 4503): wnotiboard-popup-control.c: _ctrl_lcd_on_cb(141) > There is no additional work.
05-31 10:44:36.725+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1258) > [_on_lcd_signal_receive_cb:1258] _on_lcd_signal_receive_cb, 1258, Pre LCD on by [unknown] after screen off time [11129]ms
05-31 10:44:36.725+0700 W/STARTER (  711): clock-mgr.c: _pre_lcd_on(1027) > [_pre_lcd_on:1027] Will LCD ON as reserved app[(null)] alpm mode[0]
05-31 10:44:36.725+0700 W/W_HOME  (  970): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-31 10:44:36.725+0700 W/W_HOME  (  970): gesture.c: _manual_render_disable_timer_set(167) > timer set
05-31 10:44:36.725+0700 W/W_HOME  (  970): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-31 10:44:36.725+0700 W/W_HOME  (  970): gesture.c: _apps_status_get(128) > apps status:0
05-31 10:44:36.725+0700 W/W_HOME  (  970): gesture.c: _lcd_on_cb(303) > move_to_clock:0 clock_visible:0 info->offtime:11129
05-31 10:44:36.725+0700 W/W_HOME  (  970): gesture.c: _manual_render_schedule(209) > schedule, manual render
05-31 10:44:36.725+0700 W/W_HOME  (  970): event_manager.c: _lcd_on_cb(715) > lcd state: 1
05-31 10:44:36.725+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 10:44:36.745+0700 I/APP_CORE(18143): appcore-efl.c: __do_app(453) > [APP 18143] Event: RESUME State: PAUSED
05-31 10:44:36.745+0700 I/CAPI_APPFW_APPLICATION(18143): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 10:44:36.820+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(970) > [0;32mINFO: LCDOn receive data : 1075006220[0;m
05-31 10:44:36.835+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [711].
05-31 10:44:36.835+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __alarm_remove_from_list(575) > [alarm-server]:Remove alarm id(880849126)
05-31 10:44:36.840+0700 W/SHealthCommon( 1277): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:1[0;m
05-31 10:44:36.845+0700 W/SHealthServiceCommon( 1277): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
05-31 10:44:36.850+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(971) > [0;32mINFO: WakeupServiceStart[0;m
05-31 10:44:36.850+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 10:44:36.850+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-31 10:44:36.860+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
05-31 10:44:36.860+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 10:44:36.860+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 31-5-2020, 15:34:32 (UTC).
05-31 10:44:36.860+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 10:44:36.860+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 10:44:36.870+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 10:44:36.875+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
05-31 10:44:36.875+0700 E/ALARM_MANAGER(  513): alarm-manager.c: alarm_manager_alarm_delete(2462) > alarm_id[880849126] is removed.
05-31 10:44:36.875+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 10:44:36.880+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1271) > [_on_lcd_signal_receive_cb:1271] _on_lcd_signal_receive_cb, 1271, Post LCD on by [unknown]
05-31 10:44:36.880+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_on(1059) > [_post_lcd_on:1059] LCD ON as reserved app[(null)] alpm mode[0]
05-31 10:44:36.885+0700 W/SHealthServiceCommon( 1277): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1590858000000,000000, end 1590896676885,000000, calories 734,971251[0;m
05-31 10:44:36.885+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:36.895+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-31 10:44:36.900+0700 W/W_INDICATOR(  713): windicator_util.c: _pm_state_changed_cb(915) > [_pm_state_changed_cb:915] LCD on
05-31 10:44:36.900+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(57) > [windicator_ongoing_info_shealth_update:57] windicator_shealth_update
05-31 10:44:36.905+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
05-31 10:44:36.910+0700 I/HealthDataService(  823): RequestHandler.cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
05-31 10:44:36.915+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
05-31 10:44:36.915+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : none
05-31 10:44:36.915+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: 
05-31 10:44:36.915+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-31 10:44:36.920+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : 
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : 
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : 
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : 
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : 
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string :  
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(144) > [windicator_ongoing_info_shealth_update:144] [Update] SHealth status is none, so hide icon and text!
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[1]
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:44:36.920+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:44:36.920+0700 E/MESSAGE_PORT(  713): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:44:36.920+0700 E/W_INDICATOR(  713): windicator_ongoing_info_music.c: _music_is_mode_enabled(117) > [_music_is_mode_enabled:117] (!port_exist) -> _music_is_mode_enabled() return
05-31 10:44:36.920+0700 W/W_INDICATOR(  713): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[2]
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:44:36.920+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:44:36.920+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:44:36.920+0700 E/MESSAGE_PORT(  713): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:44:36.920+0700 E/W_INDICATOR(  713): windicator_quick_setting_music.c: _music_is_mode_enabled(167) > [_music_is_mode_enabled:167] (!port_exist) -> _music_is_mode_enabled() return
05-31 10:44:36.920+0700 E/EFL     (  713): <713> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
05-31 10:44:36.925+0700 W/W_HOME  (  970): gesture.c: _manual_render_disable_timer_cb(145) > timeout callback expired
05-31 10:44:36.925+0700 W/W_HOME  (  970): gesture.c: _manual_render_enable(138) > 0
05-31 10:44:36.925+0700 W/W_HOME  (  970): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-31 10:44:36.940+0700 W/W_INDICATOR(  713): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 80
05-31 10:44:36.975+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 10:44:36.975+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 10:44:36.975+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 10:44:36.975+0700 I/HIGEAR  ( 1186): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-31 10:44:36.980+0700 W/W_INDICATOR(  713): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _wifi_state_changed_cb(930) > [_wifi_state_changed_cb:930] wifi state : 2
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _wifi_state_changed_cb(974) > [_wifi_state_changed_cb:974] ap_name : (TEKY_OFFICE)
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _wifi_state_changed_cb(994) > [_wifi_state_changed_cb:994] wifi strength : 4
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _connection_icon_set(713) > [_connection_icon_set:713] type : 16 / signal : type_wifi_connected_04
05-31 10:44:36.985+0700 E/W_INDICATOR(  713): windicator_connection.c: _connection_icon_set(754) > [_connection_icon_set:754] Set Connection / show sw.icon_1 (16)(0)
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _packet_type_changed_cb(1251) > [_packet_type_changed_cb:1251] _packet_type_changed_cb
05-31 10:44:36.985+0700 E/W_INDICATOR(  713): windicator_connection.c: _packet_type_changed_cb(1261) > [_packet_type_changed_cb:1261] WIFI MODE
05-31 10:44:36.985+0700 W/W_INDICATOR(  713): windicator_connection.c: _packet_icon_set(840) > [_packet_icon_set:840] packet : 3 / signal : packet_inout_connected
05-31 10:44:36.985+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:44:36.990+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:44:36.995+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:36.995+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:36.995+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:36.995+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:36.995+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:36.995+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:36.995+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:36.995+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 2 to 1 
05-31 10:44:36.995+0700 E/wnoti-service(  878): wnoti-native-client.c: handle_cache_notification(790) > >>
05-31 10:44:36.995+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 2 -> 1
05-31 10:44:37.000+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
05-31 10:44:37.000+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:44:37.005+0700 W/SHealthServiceCommon( 1277): PedometerSensorProxy.cpp: SOnContextPedometerUpdated(171) > [1;35mpedometerMode: 1[0;m
05-31 10:44:37.010+0700 W/SHealthServiceCommon( 1277): PedometerSensorProxy.cpp: ProcessBatchSteps(323) > [1;40;33m1[0;m
05-31 10:44:37.115+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
05-31 10:44:37.115+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 0, connected : 0
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [starter:org.tizen.idled.ReservedApp]
05-31 10:44:37.135+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [starter:org.tizen.idled.ReservedApp]
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:44:37.150+0700 W/STARTER (  711): clock-mgr.c: __reserved_apps_message_received_cb(586) > [__reserved_apps_message_received_cb:586] appid[com.samsung.windicator]
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.windicator:org.tizen.idled.ReservedApp]
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:44:37.150+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:44:37.165+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: pedo_update, pendingClientInfoList.size(): 0[0;m
05-31 10:44:37.180+0700 W/W_INDICATOR(  713): windicator_dbus.c: _msg_reserved_app_cb(336) > [_msg_reserved_app_cb:336] Moment view is already shown or call is enabled. moment view [-1]
05-31 10:44:37.195+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [4710][0;m
05-31 10:44:37.240+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(pedometer_goal_achieve_percents), check retry err: -21/(2/No such file or directory).
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_goal_achieve_percents) step(-17825744) failed(2 / No such file or directory)
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(pedometer_goal_achieve_percents) error
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(best_step_goal), check retry err: -21/(2/No such file or directory).
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(best_step_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(best_step_goal) error
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_is_existing(1514) > Error : key(best_pedometer_history_count) is not exist
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_check_retry_err(507) > key(host_pedo_default_goal), check retry err: -21/(2/No such file or directory).
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: _preference_get_key(1101) > _preference_get_key(host_pedo_default_goal) step(-17825744) failed(2 / No such file or directory)
05-31 10:44:37.245+0700 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1277): preference.c: preference_get_int(1132) > preference_get_int(1277) : key(host_pedo_default_goal) error
05-31 10:44:37.245+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:37.265+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:37.290+0700 W/SHealthServiceCommon( 1277): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
05-31 10:44:37.290+0700 W/SHealthServiceCommon( 1277): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1008[0;m
05-31 10:44:37.290+0700 W/SHealthCommon( 1277): TimelineSessionStorage.cpp: OnTriggered(1290) > [1;40;33mlocalStartTime: 1590883200000,000000[0;m
05-31 10:44:37.330+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_session_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:37.330+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(168) > [1;40;33mREQUEST POWER LOCK CPU [5000][0;m
05-31 10:44:37.340+0700 E/EFL     (18143): ecore_x<18143> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=17780443 button=1
05-31 10:44:37.365+0700 W/SHealthServiceCommon( 1277): StepLevelSensorProxy.cpp: StepLevelMonitorUpdated(380) > [1;40;33mlast step level is [2][0;m
05-31 10:44:37.365+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:37.390+0700 W/SHealthCommon( 1277): CpuLock.cpp: CheckAndReset(178) > [1;40;33mRELEASE POWER LOCK CPU[0;m
05-31 10:44:37.410+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: timeline_summary_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:37.410+0700 W/SHealthServiceCommon( 1277): EnergyExpenditureFeatureController.cpp: OnTotalEnergyExpenditureChanged(119) > [1;40;33mstart 1590858000000,000000, end 1590896677414,000000, calories 738,407332[0;m
05-31 10:44:37.415+0700 W/SHealthCommon( 1277): SHealthMessagePortConnection.cpp: SendServiceMessage(558) > [1;40;33mmessageName: energy_expenditure_updated, pendingClientInfoList.size(): 0[0;m
05-31 10:44:37.415+0700 W/SHealthServiceCommon( 1277): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
05-31 10:44:37.420+0700 E/EFL     (18143): ecore_x<18143> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=17780519 button=1
05-31 10:44:37.810+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:44:37.810+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:44:37.815+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:44:37.815+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:44:37.815+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:44:37.815+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:44:37.815+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:44:37.820+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 1 -> 2
05-31 10:44:37.820+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 1 to 2 
05-31 10:44:37.820+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_OFF
05-31 10:44:37.820+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:44:37.890+0700 E/RESOURCED(  584): block-monitor.c: block_logging(123) > pid 18143(org.example.basicui) accessed /opt/usr/media/Downloads/data-2020-5-31_10-44-21.txt
05-31 10:44:37.890+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 18143 pgid = 18143
05-31 10:44:37.890+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-31 10:44:37.895+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 10:44:37.910+0700 W/CRASH_MANAGER(18238): worker.c: worker_job(1205) > 1118143626173159089667
