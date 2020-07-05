S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 21341
Date: 2020-05-31 11:10:49+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21341, uid 5000)

Register Information
r0   = 0x44801f90, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x414c128a, r5   = 0xbe7cea80
r6   = 0x417bb180, r7   = 0xbe7ceb40
r8   = 0x00000000, r9   = 0x44814f78
r10  = 0x44811e78, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbe7cea80
lr   = 0x414c0f89, pc   = 0x414c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     49064 KB
Buffers:     11192 KB
Cached:     130296 KB
VmPeak:     115740 KB
VmSize:     113704 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20248 KB
VmRSS:       20244 KB
VmData:      48684 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          66 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21341 TID = 21341
21341 21378 21379 21380 21383 

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
44784000 44785000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
447a3000 447ab000 r-xp /usr/lib/libfeedback.so.0.1.4
447ad000 447ae000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
447b6000 447b8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
447c0000 447cb000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
447d3000 447da000 r-xp /usr/lib/libmmfcommon.so.0.0.0
447e2000 447e6000 r-xp /usr/lib/libmmfsession.so.0.0.0
447ef000 447f3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
44901000 45100000 rw-p [stack:21378]
45101000 45900000 rw-p [stack:21379]
45901000 46100000 rw-p [stack:21380]
46101000 46900000 rw-p [stack:21383]
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
be7c2000 be8ba000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21341)
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
cpp: OnHealthIpcMessageSync(123) > [1;35mServer Received: SHARE_GET[0;m
05-31 11:10:43.710+0700 I/AUL     (21356): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/popup-launcher, ret : 0
05-31 11:10:43.720+0700 I/AUL     (21356): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/dbus-daemon, ret : 0
05-31 11:10:43.740+0700 I/AUL     (  716): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 11:10:43.750+0700 I/AUL     (  716): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-31 11:10:43.765+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(78) > [windicator_ongoing_info_shealth_update:78] Result : 0
05-31 11:10:43.790+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(99) > [windicator_ongoing_info_shealth_update:99] status : none
05-31 11:10:43.790+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(103) > [windicator_ongoing_info_shealth_update:103] application_id: 
05-31 11:10:43.795+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(112) > [windicator_ongoing_info_shealth_update:112] launch_operation : 
05-31 11:10:43.795+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(118) > [windicator_ongoing_info_shealth_update:118] extra_data_key : 
05-31 11:10:43.800+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(124) > [windicator_ongoing_info_shealth_update:124] extra_data_value : 
05-31 11:10:43.800+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(132) > [windicator_ongoing_info_shealth_update:132] image_path : 
05-31 11:10:43.800+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(135) > [windicator_ongoing_info_shealth_update:135] image_path_sub : 
05-31 11:10:43.805+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(138) > [windicator_ongoing_info_shealth_update:138] message_string :  
05-31 11:10:43.810+0700 W/W_INDICATOR(  713): windicator_ongoing_info_shealth.c: windicator_ongoing_info_shealth_update(144) > [windicator_ongoing_info_shealth_update:144] [Update] SHealth status is none, so hide icon and text!
05-31 11:10:43.810+0700 W/W_INDICATOR(  713): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[1]
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:10:43.810+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:10:43.810+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:10:43.835+0700 E/MESSAGE_PORT(  713): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:10:43.835+0700 E/W_INDICATOR(  713): windicator_ongoing_info_music.c: _music_is_mode_enabled(117) > [_music_is_mode_enabled:117] (!port_exist) -> _music_is_mode_enabled() return
05-31 11:10:43.835+0700 W/W_INDICATOR(  713): windicator_ongoing_info.c: windicator_ongoing_info_remove(191) > [windicator_ongoing_info_remove:191] Ongoing info type[2]
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:10:43.835+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:10:43.835+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:10:43.840+0700 E/MESSAGE_PORT(  713): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:10:43.845+0700 E/W_INDICATOR(  713): windicator_quick_setting_music.c: _music_is_mode_enabled(167) > [_music_is_mode_enabled:167] (!port_exist) -> _music_is_mode_enabled() return
05-31 11:10:43.850+0700 E/EFL     (  713): <713> elm_main.c:1622 elm_object_signal_emit() safety check failed: obj == NULL
05-31 11:10:43.865+0700 W/W_INDICATOR(  713): windicator_quick_setting_brightness.c: windicator_quick_setting_brightness_update(94) > [windicator_quick_setting_brightness_update:94] hyun 80
05-31 11:10:43.875+0700 W/W_INDICATOR(  713): windicator_connection.c: windicator_connection_resume(2158) > [windicator_connection_resume:2158] 
05-31 11:10:43.875+0700 W/W_INDICATOR(  713): windicator_connection.c: windicator_connection_resume(2164) > [windicator_connection_resume:2164] Connection is already resumed .
05-31 11:10:43.875+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:10:43.875+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:10:43.880+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_charger_status_changed_cb(176) > [_battery_charger_status_changed_cb:176] [CHARGING_UI] [Charger status] battery charge state(0) TA state(1)
05-31 11:10:43.880+0700 W/W_INDICATOR(  713): windicator_battery.c: _charging_ui_update(78) > [_charging_ui_update:78] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 0
05-31 11:10:43.880+0700 W/W_INDICATOR(  713): windicator_battery.c: _charging_ui_update(88) > [_charging_ui_update:88] [HIDE charging icon] Not connected or Battery full (5)
05-31 11:10:43.880+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_charger_status_changed_cb(190) > [_battery_charger_status_changed_cb:190] [CHARGING_UI] [Charger status] TA connected or abnormal - [Show Moment View to display charging UI]
05-31 11:10:43.885+0700 E/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_show(1583) > [windicator_moment_view_show:1583] [CHARGING_UI] Error!
05-31 11:10:43.890+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_charging_changed_cb(118) > [_battery_charging_changed_cb:118] 
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_charge_now_get(45) > [windicator_battery_charge_now_get:45] VCONFKEY_SYSMAN_BATTERY_CHARGE_NOW : 1
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_charging_changed_cb(138) > [_battery_charging_changed_cb:138] battery charge state(1) TA state(1)
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: _charging_ui_update(78) > [_charging_ui_update:78] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: _charging_ui_update(82) > [_charging_ui_update:82] [SHOW charging icon] Connected / not Full / not charge -1
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_update(98) > [windicator_battery_update:98] 
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_icon_update(313) > [_battery_icon_update:313] battery level(40), length(2)
05-31 11:10:43.900+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_icon_update(337) > [_battery_icon_update:337] 40%
05-31 11:10:43.905+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_icon_update(352) > [_battery_icon_update:352] battery_level: 40, isCharging: 1
05-31 11:10:43.905+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_icon_update(386) > [_battery_icon_update:386] battery file : change_charging_level_40
05-31 11:10:43.905+0700 W/W_INDICATOR(  713): windicator_battery.c: _battery_icon_update(526) > [_battery_icon_update:526] Normal charging status !!
05-31 11:10:43.905+0700 W/APP_CORE(  713): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:200000d
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: _fade_in_battery_layout(1494) > [_fade_in_battery_layout:1494] [CHARGING_UI][Rotation status] _fade_in_battery_layout
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_battery_layout_show(1474) > [windicator_moment_view_battery_layout_show:1474] [CHARGING_UI][LCD_ON] windicator_moment_view_battery_layout_show
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(626) > [wnidicator_moment_view_battery_image_update:626] [CHARGING_UI] ad->is_connected : 1 // ad->is_full : 4 // ad->is_charged : 1
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(639) > [wnidicator_moment_view_battery_image_update:639] [CHARGING_UI] [SHOW charging icon] Connected  &&  not Full  &&  charging
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(678) > [wnidicator_moment_view_battery_image_update:678] [CHARGING_UI] battery level 40, index 8, bg level 40
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(765) > [wnidicator_moment_view_battery_image_update:765] [CHARGING_UI] strLevel : 40, 40
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(774) > [wnidicator_moment_view_battery_image_update:774] [CHARGING_UI] Succeed to get icu str for battery_level, so set (40)
05-31 11:10:43.910+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_image_update(788) > [wnidicator_moment_view_battery_image_update:788] [Normal or Arabic] current_locale : vi_VN.UTF-8
05-31 11:10:44.160+0700 I/AUL_PAD (21342): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 11:10:44.200+0700 E/MALI    (21342): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 11:10:44.200+0700 E/MALI    (21342): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 11:10:44.200+0700 E/MALI    (21342): [gpu-ddk] devel/graphics_drv/r4p0
05-31 11:10:44.200+0700 E/MALI    (21342): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 11:10:44.200+0700 E/MALI    (21342): [coregl] devel/graphics_engine/master
05-31 11:10:44.200+0700 E/MALI    (21342): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 11:10:44.200+0700 E/MALI    (21342): �
05-31 11:10:44.215+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:10:44.215+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:10:44.220+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:10:44.220+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:10:44.220+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:10:44.220+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:10:44.220+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:10:44.220+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:10:44.220+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:10:44.220+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:10:44.220+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:10:44.220+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:10:44.220+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:10:44.220+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:10:44.655+0700 W/MM_CAMCORDER(21343): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
05-31 11:10:44.655+0700 W/MM_CAMCORDER(21343): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
05-31 11:10:44.665+0700 I/efl-extension(21343): efl_extension.c: eext_mod_init(40) > Init
05-31 11:10:44.720+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: RESUME State: PAUSED
05-31 11:10:44.720+0700 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 11:10:44.750+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1213) > [_windicator_charger_type_changed_cb:1213] [CHARGING_UI][Charger type] : 0
05-31 11:10:44.750+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1217) > [_windicator_charger_type_changed_cb:1217] [CHARGING_UI] Reset timer!
05-31 11:10:44.750+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1235) > [_windicator_charger_type_changed_cb:1235] [CHARGING_UI][Charger type] Normal charger connected or unconnected, show charging time on charging UI
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_dbus.c: windicator_dbus_get_charging_time(1131) > [windicator_dbus_get_charging_time:1131] [CHARGING_TIME] Get charging time :60
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1332) > [wnidicator_moment_view_battery_charging_time_update:1332] [CHARGING_TIME] Charging time (minute): 60
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1379) > [wnidicator_moment_view_battery_charging_time_update:1379] [CHARGING_TIME] Show hour (1), min (0)
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1407) > [wnidicator_moment_view_battery_charging_time_update:1407] [CHARGING_TIME] Show only hour
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1411) > [wnidicator_moment_view_battery_charging_time_update:1411] [CHARGING_TIME] 1 giờ
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1443) > [wnidicator_moment_view_battery_charging_time_update:1443] [CHARGING_TIME] Remaining : Còn
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): %s
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1458) > [wnidicator_moment_view_battery_charging_time_update:1458] [CHARGING_TIME] Convert string : Còn<br/>%s
05-31 11:10:44.760+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1460) > [wnidicator_moment_view_battery_charging_time_update:1460] [CHARGING_TIME] Remaining : Còn<br/>1 giờ
05-31 11:10:44.835+0700 W/AUL     (21370): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.basicui)
05-31 11:10:44.835+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:10:44.850+0700 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-31 11:10:44.860+0700 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-31 11:10:44.860+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-31 11:10:44.860+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 21370
05-31 11:10:44.880+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.basicui, table num : 7
05-31 11:10:44.880+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 11:10:44.885+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 11:10:44.885+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 11:10:44.885+0700 W/AUL_PAD (21341): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 11:10:44.885+0700 W/AUL_PAD (21341): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 11:10:44.885+0700 W/AUL_PAD (21341): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 11:10:44.885+0700 W/AUL_PAD (21341): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.basicui)
05-31 11:10:44.895+0700 E/PKGMGR_SERVER(21298): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
05-31 11:10:45.015+0700 I/efl-extension(21341): efl_extension.c: eext_mod_init(40) > Init
05-31 11:10:45.020+0700 I/UXT     (21341): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 11:10:45.035+0700 W/AUL_PAD (21341): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 11:10:45.035+0700 W/AUL_PAD (21341): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.basicui)
05-31 11:10:45.040+0700 I/CAPI_APPFW_APPLICATION(21341): app_main.c: ui_app_main(704) > app_efl_main
05-31 11:10:45.045+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_rotation_changed_cb(1309) > [_windicator_rotation_changed_cb:1309] [CHARGING_UI][Rotation status] : Finish
05-31 11:10:45.045+0700 E/W_INDICATOR(  713): windicator_dbus.c: _windicator_rotation_changed_cb(1320) > [_windicator_rotation_changed_cb:1320] [CHARGING_UI][Rotation status] moment_view_win_show (1), moment_view_layout_show (1)
05-31 11:10:45.070+0700 I/CAPI_APPFW_APPLICATION(21341): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 11:10:45.085+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.basicui) pid(21341) type(uiapp) bg(0)
05-31 11:10:45.085+0700 W/AUL     (21370): launch.c: app_request_to_launchpad(298) > request cmd(0) result(21341)
05-31 11:10:45.085+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (21341) was created
05-31 11:10:45.130+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [21341]
05-31 11:10:45.180+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(615) > [_windicator_dbus_lcd_off_completed_cb:615] LCD Off completed signal is received
05-31 11:10:45.180+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(620) > [_windicator_dbus_lcd_off_completed_cb:620] Moment bar status -> idle. (Hide Moment bar)
05-31 11:10:45.180+0700 W/W_INDICATOR(  713): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
05-31 11:10:45.185+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 11:10:45.190+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 11:10:45.190+0700 I/efl-extension(  713): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x455be398, elm_layout, time_stamp : 19348292
05-31 11:10:45.190+0700 W/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_hide_directly(1685) > [windicator_moment_view_hide_directly:1685] windicator_moment_view_hide_directly [1]
05-31 11:10:45.190+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(533) > [_windicator_dbus_lcd_changed_cb:533] LCD ON signal is received
05-31 11:10:45.195+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_changed_cb(554) > [_windicator_dbus_lcd_changed_cb:554] 554, str=[unknown],charge : 1, connected : 1
05-31 11:10:45.240+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1213) > [_windicator_charger_type_changed_cb:1213] [CHARGING_UI][Charger type] : 2
05-31 11:10:45.240+0700 E/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1222) > [_windicator_charger_type_changed_cb:1222] [CHARGING_UI] Error!
05-31 11:10:45.240+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_charger_type_changed_cb(1235) > [_windicator_charger_type_changed_cb:1235] [CHARGING_UI][Charger type] Normal charger connected or unconnected, show charging time on charging UI
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_dbus.c: windicator_dbus_get_charging_time(1131) > [windicator_dbus_get_charging_time:1131] [CHARGING_TIME] Get charging time :60
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1332) > [wnidicator_moment_view_battery_charging_time_update:1332] [CHARGING_TIME] Charging time (minute): 60
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1379) > [wnidicator_moment_view_battery_charging_time_update:1379] [CHARGING_TIME] Show hour (1), min (0)
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1407) > [wnidicator_moment_view_battery_charging_time_update:1407] [CHARGING_TIME] Show only hour
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1411) > [wnidicator_moment_view_battery_charging_time_update:1411] [CHARGING_TIME] 1 giờ
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1443) > [wnidicator_moment_view_battery_charging_time_update:1443] [CHARGING_TIME] Remaining : Còn
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): %s
05-31 11:10:45.245+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1458) > [wnidicator_moment_view_battery_charging_time_update:1458] [CHARGING_TIME] Convert string : Còn<br/>%s
05-31 11:10:45.250+0700 W/W_INDICATOR(  713): windicator_moment_view.c: wnidicator_moment_view_battery_charging_time_update(1460) > [wnidicator_moment_view_battery_charging_time_update:1460] [CHARGING_TIME] Remaining : Còn<br/>1 giờ
05-31 11:10:45.295+0700 E/EFL     (21341): ecore_evas<21341> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 11:10:45.325+0700 E/EFL     (21341): elementary<21341> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 11:10:45.385+0700 E/EFL     (21341): elementary<21341> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x417e8690) will be pushed
05-31 11:10:45.430+0700 I/basicui (21341): started
05-31 11:10:45.450+0700 W/W_INDICATOR(  713): windicator_moment_view.c: _charging_ui_fade_out_end_cb(595) > [_charging_ui_fade_out_end_cb:595] Fade out end. Call moment_view_hide
05-31 11:10:45.450+0700 E/W_INDICATOR(  713): windicator_moment_view.c: windicator_moment_view_hide(1634) > [windicator_moment_view_hide:1634] Hide Moment View , Type(1)
05-31 11:10:45.460+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 11:10:45.460+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 11:10:45.460+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 11:10:45.460+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:10:45.460+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:10:45.460+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:10:45.460+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:10:45.460+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:10:45.460+0700 I/basicui (21341): started
05-31 11:10:45.465+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 11:10:45.465+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.465+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.465+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.465+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 11:10:45.550+0700 I/APP_CORE(21341): appcore-efl.c: __do_app(453) > [APP 21341] Event: RESET State: CREATED
05-31 11:10:45.550+0700 I/CAPI_APPFW_APPLICATION(21341): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 11:10:45.565+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 11:10:45.565+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.565+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.570+0700 W/W_INDICATOR(  713): windicator_util.c: windicator_util_back_key_ungrab(879) > [windicator_util_back_key_ungrab:879] Ref count [1].
05-31 11:10:45.570+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.570+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 11:10:45.605+0700 I/APP_CORE(21341): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 11:10:45.605+0700 I/APP_CORE(21341): appcore-efl.c: __do_app(524) > [APP 21341] Initial Launching, call the resume_cb
05-31 11:10:45.605+0700 I/CAPI_APPFW_APPLICATION(21341): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 11:10:45.615+0700 W/APP_CORE(21341): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
05-31 11:10:45.710+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 11:10:45.710+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 11:10:45.710+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.710+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.710+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 11:10:45.725+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 11:10:45.725+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:10:45.725+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 11:10:45.725+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 11:10:45.725+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.730+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 11:10:45.730+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 11:10:45.730+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 11:10:45.735+0700 E/rpm-installer(21325): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-31 11:10:45.735+0700 E/rpm-installer(21325): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-31 11:10:45.740+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.740+0700 E/rpm-installer(21325): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-31 11:10:45.740+0700 W/W_HOME  (  970): main.c: home_pause(550) > clock/widget paused
05-31 11:10:45.740+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-31 11:10:45.740+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[21341] goes to (3)
05-31 11:10:45.745+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 11:10:45.745+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 11:10:45.745+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(21341) status(fg) type(uiapp)
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:10:45.750+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:10:45.750+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:10:45.750+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:10:45.750+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:10:45.750+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:10:45.755+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:10:45.755+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:10:45.755+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:10:45.755+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:10:45.755+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:10:45.755+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:10:45.755+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:10:45.755+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:10:45.755+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:10:45.755+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:10:45.800+0700 I/APP_CORE(21341): appcore-efl.c: __do_app(453) > [APP 21341] Event: RESUME State: RUNNING
05-31 11:10:45.835+0700 E/PKGMGR_SERVER(21298): pkgmgr-server.c: sighandler(486) > child NORMAL exit [21325]
05-31 11:10:45.855+0700 E/RESOURCED(  584): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/21325/oom_score_adj failed
05-31 11:10:45.860+0700 E/RESOURCED(  584): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 21325
05-31 11:10:45.930+0700 E/RESOURCED(  584): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/21325/oom_score_adj failed
05-31 11:10:45.930+0700 E/RESOURCED(  584): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 21325
05-31 11:10:45.935+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:10:45.935+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:10:45.940+0700 W/APP_CORE(  713): appcore-efl.c: __hide_cb(882) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:200000d
05-31 11:10:45.940+0700 I/APP_CORE(  713): appcore-efl.c: __do_app(453) > [APP 713] Event: PAUSE State: RUNNING
05-31 11:10:45.940+0700 I/CAPI_APPFW_APPLICATION(  713): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:10:46.155+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:10:46.170+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21341
05-31 11:10:46.170+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:10:46.175+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:10:46.180+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:10:46.200+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 21341
05-31 11:10:46.200+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:10:46.255+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:10:46.475+0700 I/AUL_PAD (21384): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 11:10:46.670+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.720+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.720+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.720+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.740+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.760+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.760+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.760+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.775+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.785+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.790+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.790+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.800+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.815+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.815+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.815+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.825+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.840+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.840+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.840+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.855+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.870+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.870+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.870+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.885+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.895+0700 E/PKGMGR_SERVER(21298): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
05-31 11:10:46.895+0700 E/PKGMGR_SERVER(21298): pkgmgr-server.c: main(2296) > package manager server terminated.
05-31 11:10:46.905+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.905+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.905+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.925+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.945+0700 I/AUL     (21343): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:46.945+0700 E/AUL     (21343): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:46.945+0700 E/AUL     (21343): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:46.975+0700 I/UXT     (21343): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 11:10:47.100+0700 E/MALI    (21343): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 11:10:47.100+0700 E/MALI    (21343): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 11:10:47.100+0700 E/MALI    (21343): [gpu-ddk] devel/graphics_drv/r4p0
05-31 11:10:47.100+0700 E/MALI    (21343): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 11:10:47.100+0700 E/MALI    (21343): [coregl] devel/graphics_engine/master
05-31 11:10:47.100+0700 E/MALI    (21343): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 11:10:47.510+0700 E/EFL     (21341): ecore_x<21341> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19350616 button=1
05-31 11:10:47.620+0700 E/EFL     (21341): ecore_x<21341> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19350724 button=1
05-31 11:10:47.850+0700 I/MALI    (21343): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
05-31 11:10:47.850+0700 E/MALI    (21343): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
05-31 11:10:47.885+0700 I/AUL     (21389): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-31 11:10:47.905+0700 I/AUL     (21389): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 11:10:47.905+0700 E/AUL     (21389): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 11:10:47.905+0700 E/AUL     (21389): aul_path.c: __get_path(169) > root_path is NULL!
05-31 11:10:48.620+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2e00002 time=19351151
05-31 11:10:48.625+0700 E/EFL     (21341): ecore_x<21341> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=19351151
05-31 11:10:48.625+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=19351151
05-31 11:10:49.840+0700 E/EFL     (21341): ecore_x<21341> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19352943 button=1
05-31 11:10:49.895+0700 E/EFL     (21341): ecore_x<21341> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19352997 button=1
05-31 11:10:50.355+0700 W/CRASH_MANAGER(21399): worker.c: worker_job(1205) > 1121341626173159089824
