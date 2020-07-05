S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 21926
Date: 2020-05-31 11:14:32+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21926, uid 5000)

Register Information
r0   = 0x4461bb88, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x414c128a, r5   = 0xbe9fca80
r6   = 0x417bb480, r7   = 0xbe9fcb40
r8   = 0x00000000, r9   = 0x44612528
r10  = 0x4460f448, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbe9fca80
lr   = 0x414c0f89, pc   = 0x414c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     30580 KB
Buffers:     13068 KB
Cached:     138344 KB
VmPeak:     114700 KB
VmSize:     112664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20216 KB
VmRSS:       20212 KB
VmData:      47644 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21926 TID = 21926
21926 21964 21965 21966 21969 

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
44785000 44f84000 rw-p [stack:21964]
44f85000 45784000 rw-p [stack:21965]
45785000 45f84000 rw-p [stack:21966]
45f84000 45f85000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45fa3000 45fab000 r-xp /usr/lib/libfeedback.so.0.1.4
45fad000 45fae000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45fb6000 45fb8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45fc0000 45fcb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
45fd3000 45fda000 r-xp /usr/lib/libmmfcommon.so.0.0.0
45fe2000 45fe6000 r-xp /usr/lib/libmmfsession.so.0.0.0
45fef000 45ff3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
46101000 46900000 rw-p [stack:21969]
4697f000 46997000 r-xp /usr/lib/libmmfsound.so.0.1.0
469a8000 469b3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
469c0000 469d6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
469de000 46a3f000 r-xp /usr/lib/libasound.so.2.0.0
46a49000 46a4c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46a54000 46a8c000 r-xp /usr/lib/libpulse.so.0.16.2
46a8d000 46a90000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
46a98000 46ae1000 r-xp /usr/lib/libmdm.so.1.2.70
46aea000 46aed000 r-xp /usr/lib/libtinycompress.so.0.0.0
46af5000 46afa000 r-xp /usr/lib/libjson.so.0.0.1
46b02000 46b4b000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46b54000 46b9b000 r-xp /usr/lib/libsndfile.so.1.0.26
46ba7000 46bb7000 r-xp /usr/lib/libmdm-common.so.1.1.25
46bbf000 46be1000 r-xp /usr/lib/libvorbis.so.0.4.3
46be9000 46bed000 r-xp /usr/lib/libogg.so.0.7.1
be9f0000 beae8000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21926)
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
e:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:26.280+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 11:14:26.285+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 11:14:26.285+0700 I/APP_CORE(21635): appcore-efl.c: __do_app(453) > [APP 21635] Event: RESUME State: RUNNING
05-31 11:14:26.285+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:14:26.285+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 11:14:26.285+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 11:14:26.285+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:26.285+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:26.285+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:26.285+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 11:14:26.285+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:14:26.290+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:26.290+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:26.295+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 11:14:26.295+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 11:14:26.295+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 11:14:26.300+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[21635] goes to (3)
05-31 11:14:26.305+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(21635) status(fg) type(uiapp)
05-31 11:14:26.310+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[17]
05-31 11:14:26.310+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 11:14:26.310+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [basicui:17] Focused[1], focusIdx[17]
05-31 11:14:26.310+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:26.310+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:26.310+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:26.310+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:26.310+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:26.315+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:26.315+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:26.315+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:26.315+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:26.315+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:26.315+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:26.315+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:26.315+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:26.315+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:14:26.315+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:26.315+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:14:26.355+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 11:14:26.365+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19569468 button=1
05-31 11:14:26.470+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19569578 button=1
05-31 11:14:26.680+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:26.815+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:14:27.190+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19570294 button=1
05-31 11:14:27.230+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:27.245+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21635
05-31 11:14:27.245+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:27.270+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:27.280+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21635
05-31 11:14:27.285+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:27.320+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19570425 button=1
05-31 11:14:27.655+0700 I/AUL_PAD (21926): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 11:14:28.320+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x5e00002 time=19570836
05-31 11:14:28.330+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=19570836
05-31 11:14:28.330+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=19570836
05-31 11:14:28.680+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 11:14:28.680+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 11:14:28.680+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:14:28.680+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:14:28.680+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:14:28.680+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:14:28.680+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:14:28.685+0700 W/W_HOME  (  970): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-31 11:14:28.685+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveGestureChanged(995) > [0;32mINFO: wakeup receive data : 1127407240[0;m
05-31 11:14:28.685+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveGestureChanged(996) > [0;32mINFO: WakeupServiceStart[0;m
05-31 11:14:28.685+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupServiceStart(367) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-31 11:14:28.685+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_set_param(1287) > [SVOICE] set param [keyword length] : 0
05-31 11:14:28.700+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_set_param] ERROR_NONE (0x00000000)
05-31 11:14:28.700+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-31 11:14:28.705+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-31 11:14:28.705+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Enable start
05-31 11:14:28.710+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Enable end. (ret: 0x0)
05-31 11:14:28.710+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 11:14:28.710+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 1[0;m
05-31 11:14:28.710+0700 I/HIGEAR  ( 1186): WakeupService.cpp: WakeupServiceStart(393) > [svoice:Application:WakeupServiceStart:IN]
05-31 11:14:28.780+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19571885 button=1
05-31 11:14:28.870+0700 E/EFL     (21635): ecore_x<21635> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19571970 button=1
05-31 11:14:29.375+0700 E/RESOURCED(  584): block-monitor.c: block_logging(123) > pid 21635(org.example.basicui) accessed /opt/usr/media/Downloads/data-2020-5-31_11-14-27.txt
05-31 11:14:29.400+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 21635 pgid = 21635
05-31 11:14:29.400+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 2 ssi_status = 11
05-31 11:14:29.440+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (3)
05-31 11:14:29.440+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(3)
05-31 11:14:29.440+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 11:14:29.440+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 11:14:29.440+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(fg) type(uiapp)
05-31 11:14:29.450+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ed95b8] swap changed from sync to async
05-31 11:14:29.565+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-31 11:14:29.570+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 11:14:29.570+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 11:14:29.575+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.575+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.575+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.575+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:29.575+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 11:14:29.580+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 21635
05-31 11:14:29.580+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(21635)
05-31 11:14:29.615+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:29.625+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(0)
05-31 11:14:29.625+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
05-31 11:14:29.625+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.625+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.640+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(0)
05-31 11:14:29.640+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: RESUME State: PAUSED
05-31 11:14:29.645+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 11:14:29.645+0700 W/W_HOME  (  970): main.c: _appcore_resume_cb(480) > appcore resume
05-31 11:14:29.645+0700 W/W_HOME  (  970): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
05-31 11:14:29.645+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.645+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 11:14:29.645+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 11:14:29.645+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:14:29.645+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:14:29.645+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:14:29.645+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:14:29.645+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:14:29.655+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 11:14:29.655+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 11:14:29.655+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:14:29.655+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:14:29.655+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:14:29.655+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:14:29.655+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:14:29.655+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.655+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:29.655+0700 W/APPS    (  970): apps_main.c: _time_changed_cb(409) >  date : 31->31
05-31 11:14:29.655+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 11:14:29.655+0700 W/W_HOME  (  970): rotary.c: rotary_attach(138) > rotary_attach:0x46b6f488
05-31 11:14:29.655+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46b6f488, elm_layout, _activated_obj : 0x460c2aa8, activated : 1
05-31 11:14:29.655+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:14:29.655+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:29.655+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:29.655+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:29.655+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:29.660+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 11:14:29.660+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:29.660+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 11:14:29.660+0700 W/CRASH_MANAGER(21939): worker.c: worker_job(1205) > 11216356261731590898468
05-31 11:14:30.170+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 11:14:30.370+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19573473 button=1
05-31 11:14:30.370+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.370+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.370+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [288, 224]
05-31 11:14:30.370+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 11:14:30.385+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.395+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.405+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.425+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:30.440+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19573544 button=1
05-31 11:14:30.440+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [288, 224]->[285, 223]
05-31 11:14:30.440+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[17], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 11:14:30.440+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,17]
05-31 11:14:30.440+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 11:14:30.440+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(502) >  item(basicui) launched, open(0), tts(0)
05-31 11:14:30.440+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.basicui)
05-31 11:14:30.440+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:30.445+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:30.445+0700 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-31 11:14:30.460+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.basicui, table num : 8
05-31 11:14:30.465+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 11:14:30.465+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 11:14:30.465+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 11:14:30.465+0700 W/AUL_PAD (21926): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 11:14:30.465+0700 W/AUL_PAD (21926): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 11:14:30.465+0700 W/AUL_PAD (21926): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 11:14:30.465+0700 W/AUL_PAD (21926): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.basicui)
05-31 11:14:30.515+0700 I/efl-extension(21926): efl_extension.c: eext_mod_init(40) > Init
05-31 11:14:30.520+0700 I/UXT     (21926): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 11:14:30.525+0700 W/AUL_PAD (21926): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 11:14:30.525+0700 W/AUL_PAD (21926): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.basicui)
05-31 11:14:30.530+0700 I/CAPI_APPFW_APPLICATION(21926): app_main.c: ui_app_main(704) > app_efl_main
05-31 11:14:30.535+0700 I/CAPI_APPFW_APPLICATION(21926): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 11:14:30.565+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.basicui) pid(21926) type(uiapp) bg(0)
05-31 11:14:30.565+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (21926) was created
05-31 11:14:30.565+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:30.565+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21926)
05-31 11:14:30.565+0700 W/W_HOME  (  970): util.c: apps_util_launch_main_operation(785) > Launch app:[basicui] ret:[0]
05-31 11:14:30.575+0700 W/W_HOME  (  970): util.c: send_launch_appId(620) > launch appid[org.example.basicui]
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 11:14:30.575+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: IsPreloaded(395) > _MessagePortService::IsPreloaded
05-31 11:14:30.595+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [21926]
05-31 11:14:30.620+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 11:14:30.630+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:30.630+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(536) >  appid(org.example.basicui)  pkgid(org.example.basicui), name(basicui)
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:30.655+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:30.655+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:30.655+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:30.655+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:30.655+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:30.655+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:30.660+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:30.660+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:30.660+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:30.660+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:30.660+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:30.660+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:30.700+0700 E/EFL     (21926): ecore_evas<21926> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 11:14:30.720+0700 E/EFL     (21926): elementary<21926> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 11:14:30.760+0700 E/EFL     (21926): elementary<21926> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x417e8ad0) will be pushed
05-31 11:14:30.800+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: _setWidgetContentInfo(1582) >  0x45924078, com.samsung.stopwatch-wc1|35|0 com.samsung.shealth|34|0 com.samsung.w-magazine-wc1|32|0 org.example.sensorapp|33|0 org.example.basicui|37|0 org.example.collectdata|29|0, 37
05-31 11:14:30.800+0700 I/CAPI_WIDGET_APPLICATION(13571): widget_app.c: __provider_update_cb(281) > received updating signal
05-31 11:14:30.810+0700 I/basicui (21926): started
05-31 11:14:30.835+0700 I/basicui (21926): started
05-31 11:14:30.865+0700 I/APP_CORE(21926): appcore-efl.c: __do_app(453) > [APP 21926] Event: RESET State: CREATED
05-31 11:14:30.865+0700 I/CAPI_APPFW_APPLICATION(21926): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 11:14:30.880+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 11:14:30.880+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.880+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.880+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.880+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:30.880+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 11:14:30.880+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:30.880+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:30.915+0700 I/APP_CORE(21926): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 11:14:30.915+0700 I/APP_CORE(21926): appcore-efl.c: __do_app(524) > [APP 21926] Initial Launching, call the resume_cb
05-31 11:14:30.915+0700 I/CAPI_APPFW_APPLICATION(21926): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 11:14:30.925+0700 W/APP_CORE(21926): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
05-31 11:14:30.970+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 11:14:30.970+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 11:14:30.970+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.970+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.970+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 11:14:30.975+0700 I/APP_CORE(21926): appcore-efl.c: __do_app(453) > [APP 21926] Event: RESUME State: RUNNING
05-31 11:14:30.975+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 11:14:30.975+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:14:30.975+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 11:14:30.975+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 11:14:30.975+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.975+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.975+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:30.975+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 11:14:30.975+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:14:30.980+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 11:14:30.985+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(21926) status(fg) type(uiapp)
05-31 11:14:30.985+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 11:14:30.985+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 11:14:30.985+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[21926] goes to (3)
05-31 11:14:30.995+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[17]
05-31 11:14:30.995+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 11:14:30.995+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [basicui:17] Focused[1], focusIdx[17]
05-31 11:14:31.000+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:31.000+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:31.000+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:31.005+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:31.005+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:31.005+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:31.010+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:31.010+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:31.010+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:31.010+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:31.010+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:31.010+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:31.010+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:31.010+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:14:31.010+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:31.010+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:14:31.015+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:31.040+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:31.045+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 11:14:31.345+0700 E/EFL     (21926): ecore_x<21926> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19574451 button=1
05-31 11:14:31.370+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:31.465+0700 E/EFL     (21926): ecore_x<21926> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19574572 button=1
05-31 11:14:31.510+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:14:31.660+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:31.670+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21926
05-31 11:14:31.675+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:31.690+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:31.695+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21926
05-31 11:14:31.700+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:32.140+0700 E/EFL     (21926): ecore_x<21926> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19575247 button=1
05-31 11:14:32.255+0700 E/EFL     (21926): ecore_x<21926> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19575357 button=1
05-31 11:14:32.445+0700 W/CRASH_MANAGER(21939): worker.c: worker_job(1205) > 1121926626173159089847
