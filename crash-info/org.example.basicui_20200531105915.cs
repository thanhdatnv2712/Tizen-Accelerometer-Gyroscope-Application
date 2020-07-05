S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 20134
Date: 2020-05-31 10:59:15+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20134, uid 5000)

Register Information
r0   = 0x44553f08, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x413e228a, r5   = 0xbeb08a80
r6   = 0x41627178, r7   = 0xbeb08b40
r8   = 0x00000000, r9   = 0x4454dae8
r10  = 0x44548f30, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbeb08a80
lr   = 0x413e1f89, pc   = 0x413e1f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     17652 KB
Buffers:     29332 KB
Cached:     139972 KB
VmPeak:     113824 KB
VmSize:     111788 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20248 KB
VmRSS:       20244 KB
VmData:      46768 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 20134 TID = 20134
20134 20184 20185 20186 20189 

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
41391000 41395000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4139d000 413a5000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
413a7000 413ac000 r-xp /usr/lib/libappcore-common.so.1.1
413b4000 413b6000 r-xp /usr/lib/libiniparser.so.0
413bf000 413e0000 rw-p [heap]
413e0000 413e3000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
413f6000 413fa000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
41403000 41405000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
4140e000 41414000 r-xp /usr/lib/libappsvc.so.0.1.0
4141c000 41440000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41449000 41518000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4152e000 41538000 r-xp /lib/libnss_files-2.13.so
417d5000 417e0000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
417eb000 417f7000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
41800000 41821000 r-xp /usr/lib/libefl-extension.so.0.1.0
41829000 41853000 r-xp /usr/lib/libsensor.so.1.9.7
4185c000 41863000 r-xp /usr/lib/libctx-shared.so.0.8.3
4186b000 41870000 r-xp /usr/lib/libctx-client.so.0.8.3
41878000 4188a000 r-xp /usr/lib/libefl-assist.so.0.1.0
41892000 4194a000 r-xp /usr/lib/libcairo.so.2.11200.14
41955000 4195f000 r-xp /usr/lib/libsensord-shared.so
41968000 41977000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41980000 41996000 r-xp /usr/lib/libtts.so
4199f000 419c2000 r-xp /usr/lib/libui-extension.so.0.1.0
419cb000 419d6000 r-xp /usr/lib/libtbm.so.1.0.0
419de000 419ec000 r-xp /usr/lib/libGLESv2.so.2.0
419f5000 419f6000 r-xp /usr/lib/libxcb-shm.so.0.0.0
419ff000 41a05000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a0d000 41a10000 r-xp /usr/lib/libEGL.so.1.4
41a18000 41a1d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a25000 41a28000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a30000 41a31000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a3a000 41bc2000 r-xp /usr/lib/libicui18n.so.57.1
41bd2000 41cd8000 r-xp /usr/lib/libicuuc.so.57.1
41cee000 41cf6000 r-xp /usr/lib/libdrm.so.2.4.0
41cfe000 41d00000 r-xp /usr/lib/libdri2.so.0.0.0
41d08000 41d0e000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d16000 41d1b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d23000 41d3c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435dd000 435fe000 r-xp /usr/lib/libexif.so.12.3.3
43611000 43613000 r-xp /usr/lib/libttrace.so.1.1
4361b000 43620000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43628000 4362e000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43637000 4363f000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43647000 43669000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43672000 43679000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43682000 43684000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4368c000 43693000 r-xp /usr/lib/libminizip.so.1.0.0
4369b000 436a8000 r-xp /usr/lib/libail.so.0.1.0
436b1000 436b7000 r-xp /usr/lib/libproc-stat.so.0.2.96
436bf000 436c0000 r-xp /usr/lib/libresponse.so.0.2.96
436c8000 436cd000 r-xp /usr/lib/libsystem.so.0.0.0
437d7000 438a1000 r-xp /usr/lib/libCOREGL.so.4.0
43c12000 43c1d000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43c26000 43c2b000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43c33000 43c4a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c57000 43c59000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
447a7000 44fa6000 rw-p [stack:20184]
44fa7000 457a6000 rw-p [stack:20185]
457a7000 45fa6000 rw-p [stack:20186]
45fa7000 467a6000 rw-p [stack:20189]
46825000 46826000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46844000 4684c000 r-xp /usr/lib/libfeedback.so.0.1.4
4684e000 4684f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46857000 46859000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
46861000 4686c000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
46874000 4687b000 r-xp /usr/lib/libmmfcommon.so.0.0.0
46883000 4689b000 r-xp /usr/lib/libmmfsound.so.0.1.0
468ac000 468b0000 r-xp /usr/lib/libmmfsession.so.0.0.0
468b9000 468c4000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
468d1000 468d5000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
468dd000 468f3000 r-xp /usr/lib/libavsysaudio.so.0.0.1
468fb000 4695c000 r-xp /usr/lib/libasound.so.2.0.0
46966000 46969000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46971000 469a9000 r-xp /usr/lib/libpulse.so.0.16.2
469aa000 469ad000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
469b5000 469fe000 r-xp /usr/lib/libmdm.so.1.2.70
46a07000 46a0a000 r-xp /usr/lib/libtinycompress.so.0.0.0
46a12000 46a17000 r-xp /usr/lib/libjson.so.0.0.1
46a1f000 46a68000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46a71000 46ab8000 r-xp /usr/lib/libsndfile.so.1.0.26
46ac4000 46ad4000 r-xp /usr/lib/libmdm-common.so.1.1.25
46adc000 46afe000 r-xp /usr/lib/libvorbis.so.0.4.3
46b06000 46b0a000 r-xp /usr/lib/libogg.so.0.7.1
beafc000 bebf4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20134)
Call Stack Count: 18
 0: save_data + 0x7d (0x413e1f8a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1f8a
 1: _button_click_cb + 0x148 (0x413e1c51) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1c51
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
13: ui_app_main + 0xb0 (0x41393421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
14: main + 0x12e (0x413e1477) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1477
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
uto launch is disabled
05-31 10:59:08.895+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
05-31 10:59:09.165+0700 I/AUL_PAD (20134): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:59:10.085+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.085+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653189
05-31 10:59:10.085+0700 W/APPS    (  970): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
05-31 10:59:10.085+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[17], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[1]
05-31 10:59:10.085+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:10.090+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.215+0700 E/PKGMGR_OBSERVER(20120): pkg_observer.c: __pkg_observer_cb(586) > pkg observer info : req_id[201200002] pkg_type[tpk] pkgid[org.example.basicui] key[end] val[ok]
05-31 10:59:10.245+0700 W/AUL_AMD (  507): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(984) > pkgid(org.example.basicui), key(end), value(ok)
05-31 10:59:10.245+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_log_package(4750) > package [_________] callback : [INSTALL, COMPLETED]
05-31 10:59:10.245+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(7086) > package install complete
05-31 10:59:10.245+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_package_install_event(5040) > 
05-31 10:59:10.245+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(2046) > Found in install_req_list?[0], index[-1]
05-31 10:59:10.245+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_package_install_event(5066) > triggered from Gear itself.
05-31 10:59:10.310+0700 E/STARTER (  711): pkg-monitor.c: _pkg_monitor_get_metadata(136) > [_pkg_monitor_get_metadata:136] Failed to get metadata value[-2]
05-31 10:59:10.325+0700 E/PKGMGR_INFO(20120): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(1026) > callback is stopped.
05-31 10:59:10.340+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_send_mgr_wapps_install_res(2892) > send_install_response completed : END
05-31 10:59:10.350+0700 E/PKGMGR_OBSERVER(20120): pkg_observer.c: main(620) > OBSERVER end
05-31 10:59:10.360+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: sighandler(486) > child NORMAL exit [20120]
05-31 10:59:10.385+0700 E/PKGMGR_INFO(  515): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(922) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-31 10:59:10.415+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAddItem(356) >  [basicui]
05-31 10:59:10.470+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.490+0700 W/APPS    (  970): AppsBadge.cpp: onBadgeInit(124) >  [basicui] Badge is not exist
05-31 10:59:10.490+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1273) >  This is not last index app [16:sensorcollector]
05-31 10:59:10.490+0700 E/Vi::Animations(  970): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
05-31 10:59:10.490+0700 I/Vi::Animations(  970): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
05-31 10:59:10.490+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[8]
05-31 10:59:10.490+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [1->0]
05-31 10:59:10.495+0700 E/EFL     (  970): elementary<970> elm_layout.c:1021 _elm_layout_smart_content_set() could not swallow 0x48634320 into part 'elm.swallow.event.0'
05-31 10:59:10.500+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [Đếm giờ:8] Focused[0], focusIdx[8]
05-31 10:59:10.505+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[8]
05-31 10:59:10.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:10.505+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:10.505+0700 W/APPS    (  970): db.c: apps_db_read_list(621) >  
05-31 10:59:10.525+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.570+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653576
05-31 10:59:10.575+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[18], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[0]
05-31 10:59:10.575+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3604) >  end effect
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653632
05-31 10:59:10.575+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[18], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[0]
05-31 10:59:10.575+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3604) >  end effect
05-31 10:59:10.575+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653656
05-31 10:59:10.575+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[18], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[0]
05-31 10:59:10.580+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3604) >  end effect
05-31 10:59:10.580+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653673
05-31 10:59:10.585+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[18], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[0]
05-31 10:59:10.585+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3604) >  end effect
05-31 10:59:10.585+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:10.610+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.610+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(537) > Deliver clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18653695
05-31 10:59:10.615+0700 W/APPS    (  970): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
05-31 10:59:10.615+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryForwardAnimation(3600) >  EditMode[0], focusPage[1], focusIndex[8], ItemListSize[18], FocusPrev[1], FocusNext[1], FocusRecent[0], HideNextPage[0]
05-31 10:59:10.615+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[16], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:10.615+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [sensorcollector:16] Focused[0], focusIdx[16]
05-31 10:59:10.620+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[16]
05-31 10:59:10.620+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:10.620+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:10.625+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.625+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.625+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
05-31 10:59:10.630+0700 E/APPS    (  970): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4107) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-31 10:59:10.815+0700 I/efl-extension(20135): efl_extension.c: eext_mod_init(40) > Init
05-31 10:59:10.865+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:10.895+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=0, queue_status=1] 
05-31 10:59:11.010+0700 I/UXT     (20135): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:59:11.140+0700 I/AUL_PAD (20135): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:59:11.170+0700 E/MALI    (20135): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 10:59:11.170+0700 E/MALI    (20135): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 10:59:11.170+0700 E/MALI    (20135): [gpu-ddk] devel/graphics_drv/r4p0
05-31 10:59:11.170+0700 E/MALI    (20135): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 10:59:11.170+0700 E/MALI    (20135): [coregl] devel/graphics_engine/master
05-31 10:59:11.170+0700 E/MALI    (20135): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 10:59:11.380+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:11.380+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18654486
05-31 10:59:11.380+0700 W/APPS    (  970): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
05-31 10:59:11.380+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[2], focusIndex[16], ItemList size[18], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:11.380+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[15], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[1], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:11.380+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:11.385+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:11.445+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:11.460+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:11.460+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18654550
05-31 10:59:11.460+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[2], focusIndex[16], ItemList size[18], FocusPrev[1], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:11.460+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[15], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:11.465+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [sensorapp:15] Focused[0], focusIdx[15]
05-31 10:59:11.465+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[15]
05-31 10:59:11.470+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:11.470+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:11.470+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:11.480+0700 E/APPS    (  970): AppsViewNecklace.cpp: runEmptyBoxBackwardAnimation(4198) >  (!__pEmptyBox) -> runEmptyBoxBackwardAnimation() return
05-31 10:59:11.705+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:12.125+0700 W/MM_CAMCORDER(20136): mm_camcorder_internal.c: _mmcamcorder_constructor(203) >  start
05-31 10:59:12.125+0700 W/MM_CAMCORDER(20136): mm_camcorder_internal.c: _mmcamcorder_constructor(213) >  done
05-31 10:59:12.135+0700 I/efl-extension(20136): efl_extension.c: eext_mod_init(40) > Init
05-31 10:59:12.225+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.225+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.225+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18655331
05-31 10:59:12.225+0700 W/APPS    (  970): AppsViewNecklace.cpp: onRotary(5387) >  __nTimeStamp:[0], __isFastMoving[0]
05-31 10:59:12.225+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[1], focusIndex[15], ItemList size[18], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:12.225+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[14], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:12.230+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [collectdata:14] Focused[0], focusIdx[14]
05-31 10:59:12.230+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[14]
05-31 10:59:12.230+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:12.230+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:12.270+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.270+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.270+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18655373
05-31 10:59:12.270+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[1], focusIndex[14], ItemList size[18], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:12.270+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[13], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:12.270+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [collectpro:13] Focused[0], focusIdx[13]
05-31 10:59:12.275+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[13]
05-31 10:59:12.285+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:12.285+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:12.285+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:12.320+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.325+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.325+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18655426
05-31 10:59:12.325+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[1], focusIndex[13], ItemList size[18], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:12.325+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[12], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:12.330+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [Running:12] Focused[0], focusIdx[12]
05-31 10:59:12.330+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[12]
05-31 10:59:12.330+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:12.330+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:12.335+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:12.455+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.480+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:12.480+0700 I/efl-extension(  970): efl_extension_rotary.c: _rotary_rotate_handler_cb(539) > Deliver counter clockwise rotary event to object: 0x46b6f488, elm_layout, time_stamp : 18655558
05-31 10:59:12.480+0700 W/APPS    (  970): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3721) >  EditMode[0], focusPage[1], focusIndex[12], ItemList size[18], FocusPrev[0], FocusNext[0], FocusRecent[0], HideNextPage[0]
05-31 10:59:12.480+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[11], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:12.480+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [Bản đồ:11] Focused[0], focusIdx[11]
05-31 10:59:12.490+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[11]
05-31 10:59:12.490+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:12.490+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:12.490+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:12.520+0700 W/AUL     (20176): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.basicui)
05-31 10:59:12.520+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:59:12.535+0700 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
05-31 10:59:12.545+0700 I/AUL_AMD (  507): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
05-31 10:59:12.545+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1772) > no caller appid info, ret: -1
05-31 10:59:12.545+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 20176
05-31 10:59:12.555+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.basicui, table num : 6
05-31 10:59:12.555+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 10:59:12.555+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 10:59:12.555+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 10:59:12.560+0700 W/AUL_PAD (20134): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 10:59:12.560+0700 W/AUL_PAD (20134): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 10:59:12.560+0700 W/AUL_PAD (20134): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 10:59:12.560+0700 W/AUL_PAD (20134): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.basicui)
05-31 10:59:12.730+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:12.735+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 10:59:12.735+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 10:59:12.735+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:59:12.735+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:59:12.735+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:12.735+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:59:12.735+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:59:12.745+0700 E/wnoti-service(  878): wnoti-db-utility.c: context_wearonoff_status_cb(1781) > status changed from 2 to 1 
05-31 10:59:12.745+0700 E/wnoti-service(  878): wnoti-native-client.c: handle_cache_notification(790) > >>
05-31 10:59:12.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:59:12.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:12.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:59:12.745+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:59:12.745+0700 I/CLOCK-WS(12962): TimeUtil.cpp: GetStrFromIcu(424) > [1;35mts:1590897552747,000000, pattern:[a][0;m
05-31 10:59:12.745+0700 E/CLOCK-WS(12962): TimeUtil.cpp: GetStrFromIcu(505) > [0;40;31mlocale vi_VN[0;m
05-31 10:59:12.745+0700 I/CLOCK-WS(12962): TimeUtil.cpp: GetStrFromIcu(533) > [1;35mformattedString:[AM][0;m
05-31 10:59:12.750+0700 E/WMS     (  517): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(23513) > wear_monitor_status update[0] = 2 -> 1
05-31 10:59:12.750+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:532> { error=0, state=CONTEXT_WEARONOFF_MONITOR_STATUS_ON
05-31 10:59:12.750+0700 W/WECONN  (  504): <__wc_feature_wearonoff_monitor_cb:552> }
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_bool(484) > Enter [system_settings_get_value_bool]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=14
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 14, key = 14, type = 2
05-31 10:59:12.755+0700 E/rpm-installer(20121): rpm-appcore-intf.c: main(273) > ------------------------------------------------
05-31 10:59:12.755+0700 E/rpm-installer(20121): rpm-appcore-intf.c: main(274) >  [END] installer: result=[0]
05-31 10:59:12.755+0700 E/rpm-installer(20121): rpm-appcore-intf.c: main(275) > ------------------------------------------------
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:59:12.755+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:59:12.780+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: sighandler(486) > child NORMAL exit [20121]
05-31 10:59:12.850+0700 W/SHealthServiceCommon( 1277): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(347) > [1;40;33mhrValue: 1007[0;m
05-31 10:59:12.855+0700 I/efl-extension(20134): efl_extension.c: eext_mod_init(40) > Init
05-31 10:59:12.860+0700 E/RESOURCED(  584): procfs.c: proc_get_oom_score_adj(178) > fopen /proc/20121/oom_score_adj failed
05-31 10:59:12.860+0700 E/RESOURCED(  584): proc-main.c: resourced_proc_status_change(1501) > Empty pid or process not exists. 20121
05-31 10:59:12.870+0700 I/UXT     (20134): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:59:12.875+0700 W/AUL_PAD (20134): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 10:59:12.875+0700 W/AUL_PAD (20134): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.basicui)
05-31 10:59:12.880+0700 I/CAPI_APPFW_APPLICATION(20134): app_main.c: ui_app_main(704) > app_efl_main
05-31 10:59:12.885+0700 I/CAPI_APPFW_APPLICATION(20134): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 10:59:12.895+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: exit_server(1620) > exit_server Start [backend_status=1, queue_status=1] 
05-31 10:59:12.895+0700 E/PKGMGR_SERVER(20101): pkgmgr-server.c: main(2296) > package manager server terminated.
05-31 10:59:12.960+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.basicui) pid(20134) type(uiapp) bg(0)
05-31 10:59:12.960+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (20134) was created
05-31 10:59:12.960+0700 W/AUL     (20176): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20134)
05-31 10:59:13.000+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [20134]
05-31 10:59:13.055+0700 E/EFL     (20134): ecore_evas<20134> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 10:59:13.090+0700 E/EFL     (20134): elementary<20134> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 10:59:13.140+0700 E/EFL     (20134): elementary<20134> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x436ea6c8) will be pushed
05-31 10:59:13.180+0700 I/basicui (20134): started
05-31 10:59:13.210+0700 I/basicui (20134): started
05-31 10:59:13.250+0700 I/APP_CORE(20134): appcore-efl.c: __do_app(453) > [APP 20134] Event: RESET State: CREATED
05-31 10:59:13.250+0700 I/CAPI_APPFW_APPLICATION(20134): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 10:59:13.260+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 10:59:13.260+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.260+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.265+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.265+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:13.265+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 10:59:13.280+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:13.280+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:13.300+0700 I/APP_CORE(20134): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 10:59:13.300+0700 I/APP_CORE(20134): appcore-efl.c: __do_app(524) > [APP 20134] Initial Launching, call the resume_cb
05-31 10:59:13.300+0700 I/CAPI_APPFW_APPLICATION(20134): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 10:59:13.315+0700 W/APP_CORE(20134): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
05-31 10:59:13.380+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 10:59:13.380+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 10:59:13.380+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.380+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.380+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 10:59:13.385+0700 I/APP_CORE(20134): appcore-efl.c: __do_app(453) > [APP 20134] Event: RESUME State: RUNNING
05-31 10:59:13.390+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 10:59:13.390+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 10:59:13.390+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 10:59:13.390+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 10:59:13.390+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.390+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.390+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:13.390+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 10:59:13.390+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 10:59:13.400+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 10:59:13.405+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 10:59:13.405+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 10:59:13.405+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(20134) status(fg) type(uiapp)
05-31 10:59:13.420+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 10:59:13.420+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 10:59:13.420+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[20134] goes to (3)
05-31 10:59:13.425+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:59:13.425+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:59:13.425+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:59:13.425+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:59:13.425+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 10:59:13.425+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 10:59:13.430+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 10:59:13.430+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 10:59:13.430+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 10:59:13.430+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 10:59:13.435+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 10:59:13.435+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 10:59:13.435+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 10:59:13.435+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 10:59:13.435+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 10:59:13.435+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 10:59:13.480+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.480+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 10:59:13.490+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:13.495+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:13.495+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.555+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.555+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.590+0700 I/efl-extension(  970): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.590+0700 I/efl-extension(  713): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
05-31 10:59:13.780+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 10:59:13.875+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.885+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.885+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:13.885+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:13.900+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.920+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.920+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:13.920+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:13.930+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.935+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 10:59:13.955+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:13.955+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:13.955+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:13.980+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.025+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:59:14.035+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20134
05-31 10:59:14.040+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:59:14.055+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.055+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:14.055+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:14.060+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:59:14.070+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20134
05-31 10:59:14.075+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:59:14.090+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.105+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.105+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:14.105+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:14.125+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.140+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.140+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:14.140+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:14.155+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.170+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.170+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:14.170+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:14.190+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.200+0700 I/AUL     (20136): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:14.200+0700 E/AUL     (20136): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:14.200+0700 E/AUL     (20136): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:14.235+0700 I/UXT     (20136): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:59:14.330+0700 I/AUL_PAD (20196): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:59:14.355+0700 E/EFL     (20134): ecore_x<20134> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18657458 button=1
05-31 10:59:14.420+0700 E/MALI    (20136): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 10:59:14.420+0700 E/MALI    (20136): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 10:59:14.420+0700 E/MALI    (20136): [gpu-ddk] devel/graphics_drv/r4p0
05-31 10:59:14.420+0700 E/MALI    (20136): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 10:59:14.420+0700 E/MALI    (20136): [coregl] devel/graphics_engine/master
05-31 10:59:14.420+0700 E/MALI    (20136): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 10:59:14.475+0700 E/EFL     (20134): ecore_x<20134> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18657578 button=1
05-31 10:59:15.385+0700 I/MALI    (20136): egl_platform_x11_tizen.c: _tizen_platform_acquire_buffer(756) > [EGL-X11] surface has been resized, clean up all the render target [1x1] -> [360x360]
05-31 10:59:15.395+0700 E/MALI    (20136): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
05-31 10:59:15.410+0700 I/AUL     (20190): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/WebProcess, ret : 0
05-31 10:59:15.425+0700 I/AUL     (20190): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/wrt_launchpad_daemon_candidate, ret : 0
05-31 10:59:15.430+0700 E/AUL     (20190): aul_path.c: __get_pkgid(89) > Failed to get appid. (err:-1)
05-31 10:59:15.430+0700 E/AUL     (20190): aul_path.c: __get_path(169) > root_path is NULL!
05-31 10:59:15.475+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x2e00002 time=18658489
05-31 10:59:15.475+0700 E/EFL     (20134): ecore_x<20134> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=18658489
05-31 10:59:15.480+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=18658489
05-31 10:59:15.695+0700 E/EFL     (20134): ecore_x<20134> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18658795 button=1
05-31 10:59:15.820+0700 E/EFL     (20134): ecore_x<20134> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18658915 button=1
05-31 10:59:16.060+0700 W/CRASH_MANAGER(19898): worker.c: worker_job(1205) > 1120134626173159089755
