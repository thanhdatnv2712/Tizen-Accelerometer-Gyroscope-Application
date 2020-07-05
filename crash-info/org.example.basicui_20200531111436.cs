S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 21970
Date: 2020-05-31 11:14:36+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 21970, uid 5000)

Register Information
r0   = 0x46c02818, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x413c128a, r5   = 0xbe981a80
r6   = 0x419d39d8, r7   = 0xbe981b40
r8   = 0x00000000, r9   = 0x43c52a20
r10  = 0x43c4e478, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbe981a80
lr   = 0x413c0f89, pc   = 0x413c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     27864 KB
Buffers:     13164 KB
Cached:     141060 KB
VmPeak:     114884 KB
VmSize:     112848 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20284 KB
VmRSS:       20280 KB
VmData:      47828 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 21970 TID = 21970
21970 21998 21999 22000 22002 

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
413bf000 413c2000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
413d5000 413d9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
413e2000 413e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
413ed000 413f3000 r-xp /usr/lib/libappsvc.so.0.1.0
413fb000 4141f000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
41428000 414f7000 r-xp /usr/lib/libscim-1.0.so.8.2.3
4150d000 41517000 r-xp /lib/libnss_files-2.13.so
416b4000 416bf000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
416ca000 416d6000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.19
416df000 41700000 r-xp /usr/lib/libefl-extension.so.0.1.0
41708000 41732000 r-xp /usr/lib/libsensor.so.1.9.7
4173b000 41742000 r-xp /usr/lib/libctx-shared.so.0.8.3
4174a000 4174f000 r-xp /usr/lib/libctx-client.so.0.8.3
41757000 41769000 r-xp /usr/lib/libefl-assist.so.0.1.0
41771000 41829000 r-xp /usr/lib/libcairo.so.2.11200.14
41834000 4183e000 r-xp /usr/lib/libsensord-shared.so
41847000 41856000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
4185f000 41875000 r-xp /usr/lib/libtts.so
4187e000 418a1000 r-xp /usr/lib/libui-extension.so.0.1.0
418aa000 418b5000 r-xp /usr/lib/libtbm.so.1.0.0
418bd000 418be000 r-xp /usr/lib/libxcb-shm.so.0.0.0
418cb000 418cd000 rw-p [heap]
418cd000 419f9000 rw-p [heap]
419f9000 41a07000 r-xp /usr/lib/libGLESv2.so.2.0
41a10000 41a16000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a1e000 41a21000 r-xp /usr/lib/libEGL.so.1.4
41a29000 41a2e000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a36000 41a39000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a41000 41a42000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a4b000 41bd3000 r-xp /usr/lib/libicui18n.so.57.1
41be3000 41ce9000 r-xp /usr/lib/libicuuc.so.57.1
41cff000 41d07000 r-xp /usr/lib/libdrm.so.2.4.0
41d0f000 41d11000 r-xp /usr/lib/libdri2.so.0.0.0
41d19000 41d1f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d27000 41d2c000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d34000 41d4d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435ee000 4360f000 r-xp /usr/lib/libexif.so.12.3.3
43622000 43624000 r-xp /usr/lib/libttrace.so.1.1
4362c000 43631000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
43639000 4363f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
43648000 43650000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
43658000 4367a000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43683000 4368a000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43693000 43695000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4369d000 436a4000 r-xp /usr/lib/libminizip.so.1.0.0
436ac000 436b9000 r-xp /usr/lib/libail.so.0.1.0
436c2000 436c8000 r-xp /usr/lib/libproc-stat.so.0.2.96
436d0000 436d1000 r-xp /usr/lib/libresponse.so.0.2.96
436d9000 436de000 r-xp /usr/lib/libsystem.so.0.0.0
436e8000 437b2000 r-xp /usr/lib/libCOREGL.so.4.0
43b23000 43b2e000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b37000 43b3c000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b44000 43b5b000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c68000 43c6a000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
446b3000 44eb2000 rw-p [stack:21998]
44eb3000 456b2000 rw-p [stack:21999]
456b3000 45fb2000 rw-p [stack:22000]
45fb3000 467b2000 rw-p [stack:22002]
46831000 46832000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
46850000 46858000 r-xp /usr/lib/libfeedback.so.0.1.4
4685a000 4685b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
46863000 46865000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
4686d000 46878000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
46880000 46887000 r-xp /usr/lib/libmmfcommon.so.0.0.0
4688f000 468a7000 r-xp /usr/lib/libmmfsound.so.0.1.0
468b8000 468bc000 r-xp /usr/lib/libmmfsession.so.0.0.0
468c5000 468d0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
468dd000 468e1000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
468e9000 468ff000 r-xp /usr/lib/libavsysaudio.so.0.0.1
46907000 46968000 r-xp /usr/lib/libasound.so.2.0.0
46972000 46975000 r-xp /usr/lib/libpulse-simple.so.0.0.4
4697d000 469b5000 r-xp /usr/lib/libpulse.so.0.16.2
469b6000 469b9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
469c1000 46a0a000 r-xp /usr/lib/libmdm.so.1.2.70
46a13000 46a16000 r-xp /usr/lib/libtinycompress.so.0.0.0
46a1e000 46a23000 r-xp /usr/lib/libjson.so.0.0.1
46a2b000 46a74000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46a7d000 46ac4000 r-xp /usr/lib/libsndfile.so.1.0.26
46ad0000 46ae0000 r-xp /usr/lib/libmdm-common.so.1.1.25
46ae8000 46b0a000 r-xp /usr/lib/libvorbis.so.0.4.3
46b12000 46b16000 r-xp /usr/lib/libogg.so.0.7.1
be975000 bea6d000 rw-p [stack]
End of Maps Information

Callstack Information (PID:21970)
Call Stack Count: 18
 0: save_data + 0x7d (0x413c0f8a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1f8a
 1: _button_click_cb + 0x148 (0x413c0c51) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1c51
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
14: main + 0x12e (0x413c0477) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1477
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
00 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:39.425+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:39.425+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:39.430+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:39.430+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:39.430+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:39.430+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:39.430+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:39.430+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:39.430+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:39.435+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:39.435+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:39.435+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:39.435+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:14:39.440+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:39.440+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:14:39.470+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:39.470+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 11:14:39.470+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:39.625+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: _setWidgetContentInfo(1582) >  0x45924078, com.samsung.stopwatch-wc1|35|0 com.samsung.shealth|34|0 com.samsung.w-magazine-wc1|32|0 org.example.sensorapp|33|0 org.example.basicui|38|0 org.example.sensorcollector|40|0, 40
05-31 11:14:39.625+0700 I/CAPI_WIDGET_APPLICATION(13571): widget_app.c: __provider_update_cb(281) > received updating signal
05-31 11:14:39.690+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:39.760+0700 I/MALI    (22014): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43397a18] swap changed from async to sync
05-31 11:14:39.775+0700 E/EFL     (22014): ecore_x<22014> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19582872 button=1
05-31 11:14:39.885+0700 E/EFL     (22014): ecore_x<22014> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19582991 button=1
05-31 11:14:39.935+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:14:40.410+0700 I/MALI    (22014): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43397a18] swap changed from sync to async
05-31 11:14:40.470+0700 I/MALI    (22014): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43397a18] swap changed from async to sync
05-31 11:14:40.555+0700 E/EFL     (22014): ecore_x<22014> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19583661 button=1
05-31 11:14:40.705+0700 E/EFL     (22014): ecore_x<22014> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19583792 button=1
05-31 11:14:41.260+0700 W/AUL     (22045): daemon-manager-release-agent.c: main(12) > release agent : [2:/org.example.sensorcollector]
05-31 11:14:41.260+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 23
05-31 11:14:41.260+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 0
05-31 11:14:41.260+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(1032) > pkg_status: installed, dead pid: 22014
05-31 11:14:41.260+0700 W/AUL_AMD (  507): amd_request.c: __send_app_termination_signal(528) > send dead signal done
05-31 11:14:41.335+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (3)
05-31 11:14:41.335+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(3)
05-31 11:14:41.335+0700 W/AUL_AMD (  507): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-31 11:14:41.335+0700 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 11:14:41.335+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(fg) type(uiapp)
05-31 11:14:41.345+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 22014
05-31 11:14:41.345+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(22014)
05-31 11:14:41.540+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 11:14:41.540+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 11:14:41.540+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 11:14:41.540+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:14:41.540+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:14:41.540+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:14:41.540+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:14:41.540+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:14:41.620+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 11:14:41.620+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.620+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.625+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.625+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 11:14:41.625+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:41.625+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(0)
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.640+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(0)
05-31 11:14:41.640+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: RESUME State: PAUSED
05-31 11:14:41.640+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 11:14:41.640+0700 W/W_HOME  (  970): main.c: _appcore_resume_cb(480) > appcore resume
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
05-31 11:14:41.640+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.645+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.645+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:41.645+0700 W/APPS    (  970): apps_main.c: _time_changed_cb(409) >  date : 31->31
05-31 11:14:41.645+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 11:14:41.645+0700 W/W_HOME  (  970): rotary.c: rotary_attach(138) > rotary_attach:0x46b6f488
05-31 11:14:41.645+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46b6f488, elm_layout, _activated_obj : 0x460c2aa8, activated : 1
05-31 11:14:41.645+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:14:41.650+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:41.650+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:41.655+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 11:14:41.655+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:41.655+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 11:14:41.685+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:41.715+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:42.090+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 11:14:42.265+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19585370 button=1
05-31 11:14:42.265+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.265+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.265+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [289, 131]
05-31 11:14:42.265+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 11:14:42.295+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.300+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.340+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.350+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 11:14:42.365+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19585468 button=1
05-31 11:14:42.365+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [289, 131]->[281, 133]
05-31 11:14:42.365+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[16], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 11:14:42.365+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,16]
05-31 11:14:42.365+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 11:14:42.365+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(502) >  item(sensorcollector) launched, open(0), tts(0)
05-31 11:14:42.365+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.sensorcollector)
05-31 11:14:42.365+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:42.370+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:42.370+0700 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-31 11:14:42.380+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.sensorcollector, table num : 8
05-31 11:14:42.385+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 11:14:42.385+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 11:14:42.385+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 11:14:42.385+0700 W/AUL_PAD (22004): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 11:14:42.390+0700 W/AUL_PAD (22004): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 11:14:42.390+0700 W/AUL_PAD (22004): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 11:14:42.390+0700 W/AUL_PAD (22004): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.sensorcollector)
05-31 11:14:42.475+0700 I/efl-extension(22004): efl_extension.c: eext_mod_init(40) > Init
05-31 11:14:42.480+0700 I/UXT     (22004): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 11:14:42.485+0700 W/AUL_PAD (22004): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 11:14:42.485+0700 W/AUL_PAD (22004): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.sensorcollector)
05-31 11:14:42.485+0700 I/CAPI_APPFW_APPLICATION(22004): app_main.c: ui_app_main(704) > app_efl_main
05-31 11:14:42.490+0700 I/CAPI_APPFW_APPLICATION(22004): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 11:14:42.585+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.sensorcollector) pid(22004) type(uiapp) bg(0)
05-31 11:14:42.585+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (22004) was created
05-31 11:14:42.585+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:42.585+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(22004)
05-31 11:14:42.585+0700 W/W_HOME  (  970): util.c: apps_util_launch_main_operation(785) > Launch app:[sensorcollector] ret:[0]
05-31 11:14:42.590+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [22004]
05-31 11:14:42.590+0700 W/W_HOME  (  970): util.c: send_launch_appId(620) > launch appid[org.example.sensorcollector]
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 11:14:42.590+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: IsPreloaded(395) > _MessagePortService::IsPreloaded
05-31 11:14:42.615+0700 E/EFL     (22004): ecore_evas<22004> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 11:14:42.640+0700 E/EFL     (22004): elementary<22004> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 11:14:42.640+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 11:14:42.645+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:42.645+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(536) >  appid(org.example.sensorcollector)  pkgid(org.example.sensorcollector), name(sensorcollector)
05-31 11:14:42.655+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:42.655+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:42.655+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:42.660+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:42.660+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:42.660+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:42.660+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:42.660+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:42.660+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:42.665+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:42.665+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:42.665+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:42.665+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:42.665+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:42.665+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:42.665+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:42.670+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:42.670+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:42.670+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:42.700+0700 E/EFL     (22004): elementary<22004> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x436ecbe8) will be pushed
05-31 11:14:42.760+0700 I/basicui (22004): started
05-31 11:14:42.785+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: _setWidgetContentInfo(1582) >  0x45924078, com.samsung.stopwatch-wc1|35|0 com.samsung.shealth|34|0 com.samsung.w-magazine-wc1|32|0 org.example.sensorapp|33|0 org.example.basicui|38|0 org.example.sensorcollector|41|0, 41
05-31 11:14:42.785+0700 I/CAPI_WIDGET_APPLICATION(13571): widget_app.c: __provider_update_cb(281) > received updating signal
05-31 11:14:42.795+0700 I/basicui (22004): started
05-31 11:14:42.810+0700 I/APP_CORE(22004): appcore-efl.c: __do_app(453) > [APP 22004] Event: RESET State: CREATED
05-31 11:14:42.810+0700 I/CAPI_APPFW_APPLICATION(22004): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 11:14:42.840+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 11:14:42.840+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.840+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.845+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.845+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:42.845+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 11:14:42.845+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:42.845+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:42.875+0700 I/APP_CORE(22004): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 11:14:42.880+0700 I/APP_CORE(22004): appcore-efl.c: __do_app(524) > [APP 22004] Initial Launching, call the resume_cb
05-31 11:14:42.880+0700 I/CAPI_APPFW_APPLICATION(22004): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 11:14:42.890+0700 W/APP_CORE(22004): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4e00002
05-31 11:14:42.940+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 11:14:42.940+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 11:14:42.940+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.940+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.945+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 11:14:42.945+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 11:14:42.945+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 11:14:42.945+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 11:14:42.945+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 11:14:42.945+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.950+0700 I/APP_CORE(22004): appcore-efl.c: __do_app(453) > [APP 22004] Event: RESUME State: RUNNING
05-31 11:14:42.960+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.960+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:42.960+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 11:14:42.960+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 11:14:42.970+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 11:14:42.970+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [sensorcollector:16] Focused[1], focusIdx[16]
05-31 11:14:42.970+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[16]
05-31 11:14:42.970+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 11:14:42.975+0700 E/TBM     (  461): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:461] error(Device or resource busy) _tgl_destroy:141 key:33
05-31 11:14:42.975+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 11:14:42.975+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 11:14:42.975+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 11:14:42.980+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 11:14:42.980+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 11:14:42.980+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 11:14:42.980+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[22004] goes to (3)
05-31 11:14:42.980+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 11:14:42.985+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 11:14:42.985+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 11:14:42.985+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 11:14:42.985+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 11:14:42.985+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 11:14:42.985+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 11:14:42.990+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 11:14:42.990+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 11:14:42.990+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 11:14:42.990+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 11:14:42.990+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 11:14:42.990+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 11:14:43.000+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.sensorcollector) pid(22004) status(fg) type(uiapp)
05-31 11:14:43.015+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 11:14:43.020+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 11:14:43.265+0700 E/EFL     (22004): ecore_x<22004> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=19586372 button=1
05-31 11:14:43.355+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 11:14:43.385+0700 E/EFL     (22004): ecore_x<22004> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=19586492 button=1
05-31 11:14:43.490+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 11:14:43.675+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:43.685+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22004
05-31 11:14:43.690+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:44.195+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 11:14:44.205+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 22004
05-31 11:14:44.300+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 11:14:44.395+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4e00002 time=19587030
05-31 11:14:44.405+0700 E/EFL     (22004): ecore_x<22004> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=19587030
05-31 11:14:44.405+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=19587030
05-31 11:14:45.150+0700 I/AUL_PAD (22068): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 11:14:45.400+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1298) > _signal_context_handler: type: 0, state: 3
05-31 11:14:45.400+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_context_handler(1315) > Call the time_tick_cb
05-31 11:14:45.400+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 11:14:45.400+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 11:14:45.400+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 11:14:45.400+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 11:14:45.400+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 11:14:45.430+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_lcd_status_handler(1231) > signal_lcd_status_signal: LCDOff
05-31 11:14:45.440+0700 W/W_HOME  (  970): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-31 11:14:45.440+0700 W/W_HOME  (  970): gesture.c: _manual_render_cancel_schedule(226) > cancel schedule, manual render
05-31 11:14:45.440+0700 W/W_HOME  (  970): gesture.c: _manual_render_disable_timer_del(157) > timer del
05-31 11:14:45.440+0700 W/W_HOME  (  970): gesture.c: _manual_render_enable(138) > 1
05-31 11:14:45.440+0700 W/W_HOME  (  970): event_manager.c: _lcd_off_cb(723) > lcd state: 0
05-31 11:14:45.440+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:1(0) pm_state:0 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 11:14:45.445+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1284) > [_on_lcd_signal_receive_cb:1284] _on_lcd_signal_receive_cb, 1284, Pre LCD off by [gesture]
05-31 11:14:45.445+0700 W/STARTER (  711): clock-mgr.c: _pre_lcd_off(1089) > [_pre_lcd_off:1089] Will LCD OFF as wake_up_setting[1]
05-31 11:14:45.445+0700 E/STARTER (  711): scontext_util.c: sconstext_util_check_lock_type(47) > [sconstext_util_check_lock_type:47] current lock state :[0],testmode[0]
05-31 11:14:45.445+0700 E/STARTER (  711): scontext_util.c: scontext_util_handle_lock_state(72) > [scontext_util_handle_lock_state:72] wear state[0],bPossible [0],usage [0]
05-31 11:14:45.450+0700 W/STARTER (  711): clock-mgr.c: _check_reserved_popup_status(211) > [_check_reserved_popup_status:211] Current reserved apps status : 0
05-31 11:14:45.450+0700 W/STARTER (  711): clock-mgr.c: _check_reserved_apps_status(247) > [_check_reserved_apps_status:247] Current reserved apps status : 0
05-31 11:14:45.465+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(979) > [0;32mINFO: LCDOff receive data : 1075006220[0;m
05-31 11:14:45.470+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: OnReceiveDisplayChanged(980) > [0;32mINFO: WakeupServiceStop[0;m
05-31 11:14:45.480+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupServiceStop(399) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-31 11:14:45.480+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(288) > [0;31mERROR: db/private/com.samsung.wfmw/is_locked FAILED[0;m
05-31 11:14:45.485+0700 E/WAKEUP-SERVICE( 1186): WakeupService.cpp: _WakeupIsAvailable(314) > [0;31mERROR: file/calendar/alarm_state FAILED[0;m
05-31 11:14:45.490+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1255) > [SVOICE] Wake up Disable start
05-31 11:14:45.510+0700 I/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1258) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-31 11:14:45.525+0700 W/TIZEN_N_SOUND_MANAGER( 1186): sound_manager_private.c: __convert_sound_manager_error_code(156) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-31 11:14:45.540+0700 W/WAKEUP-SERVICE( 1186): WakeupService.cpp: WakeupSetSeamlessValue(360) > [0;32mINFO: WAKEUP SET : 0[0;m
05-31 11:14:45.545+0700 I/HIGEAR  ( 1186): WakeupService.cpp: WakeupServiceStop(403) > [svoice:Application:WakeupServiceStop:IN]
05-31 11:14:45.610+0700 W/STARTER (  711): clock-mgr.c: _on_lcd_signal_receive_cb(1297) > [_on_lcd_signal_receive_cb:1297] _on_lcd_signal_receive_cb, 1297, Post LCD off by [gesture]
05-31 11:14:45.610+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1190) > [_post_lcd_off:1190] LCD OFF as reserved app[(null)] alpm mode[0]
05-31 11:14:45.610+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1197) > [_post_lcd_off:1197] Current reserved apps status : 0
05-31 11:14:45.610+0700 W/STARTER (  711): clock-mgr.c: _post_lcd_off(1215) > [_post_lcd_off:1215] raise homescreen after 20 sec. home_visible[0]
05-31 11:14:45.610+0700 E/ALARM_MANAGER(  711): alarm-lib.c: alarmmgr_add_alarm_withcb(1178) > trigger_at_time(20), start(31-5-2020, 11:15:06), repeat(1), interval(20), type(-1073741822)
05-31 11:14:45.615+0700 W/SHealthCommon(13558): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:3[0;m
05-31 11:14:45.615+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __is_cached_cookie(230) > Find cached cookie for [711].
05-31 11:14:45.625+0700 W/W_INDICATOR(  713): windicator_util.c: _pm_state_changed_cb(920) > [_pm_state_changed_cb:920] LCD off
05-31 11:14:45.625+0700 W/W_INDICATOR(  713): windicator_connection.c: windicator_connection_pause(2268) > [windicator_connection_pause:2268] 
05-31 11:14:45.630+0700 E/W_INDICATOR(  713): windicator_connection.c: windicator_connection_pause(2287) > [windicator_connection_pause:2287] There is no handle
05-31 11:14:45.640+0700 I/APP_CORE(22004): appcore-efl.c: __do_app(453) > [APP 22004] Event: PAUSE State: RUNNING
05-31 11:14:45.640+0700 I/CAPI_APPFW_APPLICATION(22004): app_main.c: _ui_app_appcore_pause(611) > app_appcore_pause
05-31 11:14:45.640+0700 W/W_INDICATOR(  713): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
05-31 11:14:45.640+0700 W/APP_CORE(22004): appcore-efl.c: _capture_and_make_file(1721) > Capture : win[4e00002] -> redirected win[603614] for org.example.sensorcollector[22004]
05-31 11:14:45.645+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(615) > [_windicator_dbus_lcd_off_completed_cb:615] LCD Off completed signal is received
05-31 11:14:45.645+0700 W/W_INDICATOR(  713): windicator_dbus.c: _windicator_dbus_lcd_off_completed_cb(620) > [_windicator_dbus_lcd_off_completed_cb:620] Moment bar status -> idle. (Hide Moment bar)
05-31 11:14:45.645+0700 W/W_INDICATOR(  713): windicator_moment_bar.c: windicator_moment_bar_hide_directly(548) > [windicator_moment_bar_hide_directly:548] windicator_moment_bar_hide_directly
05-31 11:14:45.655+0700 W/SHealthCommon( 1277): SystemUtil.cpp: OnDeviceStatusChanged(1007) > [1;35mlcdState:3[0;m
05-31 11:14:45.655+0700 W/SHealthServiceCommon( 1277): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(645) > [1;35m ###[0;m
05-31 11:14:45.680+0700 E/ALARM_MANAGER(  513): alarm-manager-schedule.c: _alarm_next_duetime(509) > alarm_id: 338511020, next duetime: 1590898506
05-31 11:14:45.680+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __alarm_add_to_list(496) > [alarm-server]: After add alarm_id(338511020)
05-31 11:14:45.680+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __alarm_create(1061) > [alarm-server]:alarm_context.c_due_time(1590908708), due_time(1590898506)
05-31 11:14:45.700+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_lock_state(1884) > Lock LCD OFF is successfully done
05-31 11:14:45.705+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(325) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
05-31 11:14:45.705+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(332) > Setted RTC Alarm date/time is 31-5-2020, 04:15:06 (UTC).
05-31 11:14:45.705+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __rtc_set(347) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
05-31 11:14:45.705+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 11:14:45.715+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __display_unlock_state(1927) > Unlock LCD OFF is successfully done
05-31 11:14:45.715+0700 E/ALARM_MANAGER(  513): alarm-manager.c: __save_module_log(1780) > The file is not ready.
05-31 11:14:46.570+0700 W/CRASH_MANAGER(21939): worker.c: worker_job(1205) > 1121970626173159089847
