S/W Version Information
Model: SM-R732
Tizen-Version: 2.3.2.7
Build-Number: R732XXU2FRC1
Build-Date: 2018.03.02 17:21:30

Crash Information
Process Name: basicui
PID: 20196
Date: 2020-05-31 10:59:58+0700
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 20196, uid 5000)

Register Information
r0   = 0x45f2a308, r1   = 0xbe007478
r2   = 0x00000080, r3   = 0x00000000
r4   = 0x413c128a, r5   = 0xbe80fa80
r6   = 0x418587d0, r7   = 0xbe80fb40
r8   = 0x00000000, r9   = 0x43c53300
r10  = 0x43c50220, fp   = 0x00000001
ip   = 0x4138ebe4, sp   = 0xbe80fa80
lr   = 0x413c0f89, pc   = 0x413c0f8a
cpsr = 0x60000030

Memory Information
MemTotal:   490112 KB
MemFree:     17996 KB
Buffers:     28712 KB
Cached:     140380 KB
VmPeak:     113860 KB
VmSize:     111824 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20232 KB
VmRSS:       20228 KB
VmData:      46804 KB
VmStk:        1008 KB
VmExe:          20 KB
VmLib:       25396 KB
VmPTE:          62 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 20196 TID = 20196
20196 20346 20347 20348 20351 

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
4174e000 41752000 rw-p [heap]
41752000 4187e000 rw-p [heap]
4187e000 41883000 r-xp /usr/lib/libctx-client.so.0.8.3
4188b000 4189d000 r-xp /usr/lib/libefl-assist.so.0.1.0
418a5000 4195d000 r-xp /usr/lib/libcairo.so.2.11200.14
41968000 41972000 r-xp /usr/lib/libsensord-shared.so
4197b000 4198a000 r-xp /usr/lib/libjson-glib-1.0.so.0.1001.3
41993000 419a9000 r-xp /usr/lib/libtts.so
419b2000 419d5000 r-xp /usr/lib/libui-extension.so.0.1.0
419de000 419e9000 r-xp /usr/lib/libtbm.so.1.0.0
419f1000 419ff000 r-xp /usr/lib/libGLESv2.so.2.0
41a08000 41a09000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41a12000 41a18000 r-xp /usr/lib/libxcb-render.so.0.0.0
41a20000 41a23000 r-xp /usr/lib/libEGL.so.1.4
41a2b000 41a30000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41a38000 41a3b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41a43000 41a44000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
41a4d000 41bd5000 r-xp /usr/lib/libicui18n.so.57.1
41be5000 41ceb000 r-xp /usr/lib/libicuuc.so.57.1
41d01000 41d09000 r-xp /usr/lib/libdrm.so.2.4.0
41d11000 41d13000 r-xp /usr/lib/libdri2.so.0.0.0
41d1b000 41d21000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
41d29000 41d2e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
41d36000 41d4f000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.8
435f0000 43611000 r-xp /usr/lib/libexif.so.12.3.3
43624000 43626000 r-xp /usr/lib/libttrace.so.1.1
4362e000 43633000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
4363b000 43641000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
4364a000 43652000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
4365a000 4367c000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
43685000 4368c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
43695000 43697000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
4369f000 436a6000 r-xp /usr/lib/libminizip.so.1.0.0
436ae000 436bb000 r-xp /usr/lib/libail.so.0.1.0
436c4000 436ca000 r-xp /usr/lib/libproc-stat.so.0.2.96
436d2000 436d3000 r-xp /usr/lib/libresponse.so.0.2.96
436db000 436e0000 r-xp /usr/lib/libsystem.so.0.0.0
436ea000 437b4000 r-xp /usr/lib/libCOREGL.so.4.0
43b25000 43b30000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
43b39000 43b3e000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
43b46000 43b5d000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
43c6a000 43c6c000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
446b5000 44eb4000 rw-p [stack:20346]
44eb5000 456b4000 rw-p [stack:20347]
456b5000 45eb4000 rw-p [stack:20348]
45eb4000 45eb5000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
45ed3000 45edb000 r-xp /usr/lib/libfeedback.so.0.1.4
45edd000 45ede000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
45ee6000 45ee8000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.11
45ef0000 45ef7000 r-xp /usr/lib/libmmfcommon.so.0.0.0
46001000 46800000 rw-p [stack:20351]
4687f000 4688a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.54
46892000 468aa000 r-xp /usr/lib/libmmfsound.so.0.1.0
468bb000 468bf000 r-xp /usr/lib/libmmfsession.so.0.0.0
468c8000 468d3000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
468e0000 468e4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
468ec000 46902000 r-xp /usr/lib/libavsysaudio.so.0.0.1
4690a000 4696b000 r-xp /usr/lib/libasound.so.2.0.0
46975000 46978000 r-xp /usr/lib/libpulse-simple.so.0.0.4
46980000 469b8000 r-xp /usr/lib/libpulse.so.0.16.2
469b9000 469bc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
469c4000 46a0d000 r-xp /usr/lib/libmdm.so.1.2.70
46a16000 46a19000 r-xp /usr/lib/libtinycompress.so.0.0.0
46a21000 46a26000 r-xp /usr/lib/libjson.so.0.0.1
46a2e000 46a77000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
46a80000 46ac7000 r-xp /usr/lib/libsndfile.so.1.0.26
46ad3000 46ae3000 r-xp /usr/lib/libmdm-common.so.1.1.25
46aeb000 46b0d000 r-xp /usr/lib/libvorbis.so.0.4.3
46b15000 46b19000 r-xp /usr/lib/libogg.so.0.7.1
be803000 be8fb000 rw-p [stack]
End of Maps Information

Callstack Information (PID:20196)
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
 W/AUL_AMD (  507): amd_launch.c: __e17_status_handler(2391) > back key ungrab error
05-31 10:59:51.570+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(fg) type(uiapp)
05-31 10:59:51.580+0700 I/APP_CORE(20226): appcore-efl.c: __after_loop(1243) > [APP 20226] After terminate() callback
05-31 10:59:51.585+0700 E/APP_CORE(20135): appcore.c: __del_vconf(453) > [FAILED]vconfkey_ignore_key_changed
05-31 10:59:51.585+0700 I/APP_CORE(20135): appcore-efl.c: __after_loop(1232) > Legacy lifecycle: 0
05-31 10:59:51.585+0700 I/CAPI_APPFW_APPLICATION(20135): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
05-31 10:59:51.585+0700 I/APP_CORE(20135): appcore-efl.c: __after_loop(1243) > [APP 20135] After terminate() callback
05-31 10:59:51.590+0700 I/MALI    (20226): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x4145a208] swap changed from sync to async
05-31 10:59:51.590+0700 E/MALI    (20226): egl_mali.c: __egl_mali_post_to_window_surface(1183) > MALI_ERR_EARLY_OUT - Don't need to add frame callback because frame is unmodified
05-31 10:59:51.620+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(962) > Private Surface will be initialized for widget[0x450e5db0], circle_obj[0x450f8558]!
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(649) > surface 0x44df77f0 = w: 0 h: 0  obj 0x450e5db0 w: 360 h: 360
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(673) > Surface will be initialized! surface->w= 360 surface->h = 360
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x467963b0 is freed
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x45038b50 is freed
05-31 10:59:51.625+0700 I/efl-extension(20135): efl_extension_rotary.c: _object_deleted_cb(589) > In: data: 0x4503a3f0, obj: 0x4503a3f0
05-31 10:59:51.630+0700 I/efl-extension(20135): efl_extension_rotary.c: _remove_ecore_handlers(571) > In
05-31 10:59:51.630+0700 I/efl-extension(20135): efl_extension_rotary.c: _remove_ecore_handlers(576) > removed _motion_handler
05-31 10:59:51.630+0700 I/efl-extension(20135): efl_extension_rotary.c: _remove_ecore_handlers(582) > removed _rotate_handler
05-31 10:59:51.630+0700 I/efl-extension(20135): efl_extension_rotary.c: _object_deleted_cb(618) > done
05-31 10:59:51.640+0700 I/MALI    (20226): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
05-31 10:59:51.640+0700 I/MALI    (20226): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=20226   close drm_fd=23 
05-31 10:59:51.640+0700 I/MALI    (20226): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
05-31 10:59:51.645+0700 E/EFL     (20135): elementary<20135> elm_genlist.c:6965 elm_genlist_item_prev_get() Elm_Widget_Item ((Elm_Widget_Item *)item) is NULL
05-31 10:59:51.650+0700 E/EFL     (20135): elementary<20135> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4503a3f0 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
05-31 10:59:51.650+0700 E/EFL     (20135): elementary<20135> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4503a3f0 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
05-31 10:59:51.650+0700 E/EFL     (20135): elementary<20135> elm_interface_scrollable.c:1893 _elm_scroll_content_region_show_internal() [0x4503a3f0 : elm_genlist] mx(0), my(0), minx(0), miny(0), px(0), py(0)
05-31 10:59:51.650+0700 E/EFL     (20135): elementary<20135> elm_interface_scrollable.c:1894 _elm_scroll_content_region_show_internal() [0x4503a3f0 : elm_genlist] cw(0), ch(0), pw(360), ph(360)
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(687) > Surface is going to free in delete callback for image widget.
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(988) > surface 0x44df77f0 is freed
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_rotary.c: _activated_obj_del_cb(624) > _activated_obj_del_cb : 0x450e5db0
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x4503a3f0, elm_genlist, func : 0x43911ea1
05-31 10:59:51.650+0700 I/efl-extension(20135): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 10:59:51.670+0700 I/MALI    (20135): egl_platform_x11.c: __egl_platform_terminate(324) > [EGL-X11] ################################################
05-31 10:59:51.670+0700 I/MALI    (20135): egl_platform_x11.c: __egl_platform_terminate(325) > [EGL-X11] PID=20135   close drm_fd=22 
05-31 10:59:51.670+0700 I/MALI    (20135): egl_platform_x11.c: __egl_platform_terminate(326) > [EGL-X11] ################################################
05-31 10:59:51.710+0700 I/UXT     (20314): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:59:51.735+0700 W/PROCESSMGR(  461): e_mod_processmgr.c: _e_mod_processmgr_send_update_watch_action(663) > [PROCESSMGR] =====================> send UpdateClock
05-31 10:59:51.750+0700 W/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1269) > process_manager_signal
05-31 10:59:51.750+0700 I/WATCH_CORE(12962): appcore-watch.c: __signal_process_manager_handler(1285) > Call the time_tick_cb
05-31 10:59:51.750+0700 I/CAPI_WATCH_APPLICATION(12962): watch_app_main.c: _watch_core_time_tick(313) > _watch_core_time_tick
05-31 10:59:51.750+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value_string(522) > Enter [system_settings_get_value_string]
05-31 10:59:51.750+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_value(386) > Enter [system_settings_get_value]
05-31 10:59:51.750+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(361) > Enter [system_settings_get_item], key=13
05-31 10:59:51.750+0700 E/TIZEN_N_SYSTEM_SETTINGS(12962): system_settings.c: system_settings_get_item(374) > Enter [system_settings_get_item], index = 13, key = 13, type = 0
05-31 10:59:51.780+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 1 -> 0
05-31 10:59:51.780+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:0(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.785+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:51.785+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 1
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(0)
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 0 -> 1
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.785+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:2 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.785+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(0)
05-31 10:59:51.785+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: RESUME State: PAUSED
05-31 10:59:51.790+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-31 10:59:51.790+0700 W/W_HOME  (  970): main.c: _appcore_resume_cb(480) > appcore resume
05-31 10:59:51.790+0700 W/W_HOME  (  970): event_manager.c: _app_resume_cb(373) > state: 2 -> 1
05-31 10:59:51.790+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.790+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.790+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:51.790+0700 W/APPS    (  970): apps_main.c: _time_changed_cb(409) >  date : 31->31
05-31 10:59:51.790+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:51.790+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:51.795+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:51.795+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:51.795+0700 W/W_HOME  (  970): rotary.c: rotary_attach(138) > rotary_attach:0x46b6f488
05-31 10:59:51.795+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x46b6f488, elm_layout, _activated_obj : 0x460c2aa8, activated : 1
05-31 10:59:51.795+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 10:59:51.795+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:51.800+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:51.800+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 0
05-31 10:59:51.800+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 10:59:51.800+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_do_postponed_job(974) > No postponed work with is_for_VI: 0, postponed_for_VI: 0.
05-31 10:59:51.835+0700 I/AUL_PAD (20314): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:59:51.855+0700 E/MALI    (20314): egl_platform_x11.c: __egl_platform_initialize(127) > DDK VERSION - MALI400MP-r4p0-00rel0 / BUILD DATE - 8/Aug/2016 
05-31 10:59:51.855+0700 E/MALI    (20314): egl_platform_x11.c: __egl_platform_initialize(141) > model name : SM-R720
05-31 10:59:51.855+0700 E/MALI    (20314): [gpu-ddk] devel/graphics_drv/r4p0
05-31 10:59:51.855+0700 E/MALI    (20314): 97ae9c0655a7d384872f26978f48bd958e392c4b Fix image distortion on 3rd party applicaton "AnalogWatch"
05-31 10:59:51.855+0700 E/MALI    (20314): [coregl] devel/graphics_engine/master
05-31 10:59:51.855+0700 E/MALI    (20314): c936d4e43f19940f81bedb56d9006162dc3ae4e4 Add manifest file for coregl
05-31 10:59:52.305+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x43ed95b8] swap changed from async to sync
05-31 10:59:52.590+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18695693 button=1
05-31 10:59:52.590+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.590+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.590+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [107, 85]
05-31 10:59:52.590+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 10:59:52.595+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.605+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.615+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.615+0700 I/UXT     (20226): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
05-31 10:59:52.615+0700 I/UXT     (20226): uxt_theme_private.c: uxt_theme_delete_file_monitor(1662) > deleted font config file monitor
05-31 10:59:52.615+0700 I/UXT     (20226): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
05-31 10:59:52.640+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.650+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.660+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:52.700+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18695786 button=1
05-31 10:59:52.700+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [107, 85]->[111, 93]
05-31 10:59:52.700+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[8], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:52.705+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [Đếm giờ:8] Focused[0], focusIdx[8]
05-31 10:59:52.705+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[8]
05-31 10:59:52.710+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:52.710+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:52.725+0700 E/APPS    (  970): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4107) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-31 10:59:52.725+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 10:59:52.765+0700 I/UXT     (20135): uxt_theme_private.c: uxt_theme_delete_file_monitor(1655) > deleted color config file monitor
05-31 10:59:52.765+0700 I/UXT     (20135): Uxt_ObjectManager.cpp: OnTerminating(774) > Terminating.
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:59:52.840+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:59:52.840+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:59:52.845+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:59:52.845+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 10:59:52.845+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 10:59:52.845+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 10:59:52.845+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 10:59:52.845+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 10:59:52.845+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 10:59:52.850+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 10:59:52.855+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 10:59:52.855+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 10:59:52.855+0700 W/AUL_PAD (20226): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
05-31 10:59:52.860+0700 I/efl-extension(20226): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-31 10:59:52.960+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:52.980+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20226 pgid = 20226
05-31 10:59:52.980+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
05-31 10:59:53.010+0700 W/AUL_PAD (20135): launchpad_loader.c: __at_exit_to_release_bundle(301) > __at_exit_to_release_bundle
05-31 10:59:53.010+0700 I/efl-extension(20135): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-31 10:59:53.065+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-31 10:59:53.070+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20226
05-31 10:59:53.070+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20226)
05-31 10:59:53.200+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(188) > dead_pid = 20135 pgid = 20135
05-31 10:59:53.200+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(189) > ssi_code = 1 ssi_status = 0
05-31 10:59:53.295+0700 W/AUL_PAD ( 1260): sigchild.h: __launchpad_process_sigchld(197) > after __sigchild_action
05-31 10:59:53.300+0700 I/AUL_AMD (  507): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 20135
05-31 10:59:53.300+0700 W/AUL     (  507): app_signal.c: aul_send_app_terminated_signal(799) > aul_send_app_terminated_signal pid(20135)
05-31 10:59:53.515+0700 W/AUL_AMD (  507): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
05-31 10:59:53.525+0700 W/AUL_AMD (  507): amd_status.c: __app_terminate_timer_cb(168) > send SIGKILL: No such process
05-31 10:59:53.710+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x1400003 time=18696408
05-31 10:59:53.735+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=18696408
05-31 10:59:53.735+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=18696408
05-31 10:59:54.260+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18697363 button=1
05-31 10:59:54.260+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.260+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.260+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [118, 77]
05-31 10:59:54.260+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 10:59:54.270+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.280+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.290+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.305+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.335+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:54.350+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18697454 button=1
05-31 10:59:54.350+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [118, 77]->[129, 81]
05-31 10:59:54.350+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[16], anim[0], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:54.350+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [sensorcollector:16] Focused[0], focusIdx[16]
05-31 10:59:54.355+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[16]
05-31 10:59:54.355+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:54.355+0700 W/APPS    (  970): AppsViewNecklace.cpp: setBubbleColor(2479) >  [249, 249, 249, 255]
05-31 10:59:54.365+0700 E/APPS    (  970): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(4107) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
05-31 10:59:54.365+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 10:59:54.595+0700 W/APPS    (  970): AppsViewNecklace.cpp: onAutoLaunchTimerStart(5026) >  auto launch is disabled
05-31 10:59:55.670+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18698772 button=1
05-31 10:59:55.670+0700 E/EFL     (  970): ecore_x<970> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18698772 button=1
05-31 10:59:55.670+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:55.670+0700 W/W_HOME  (  970): event_manager.c: home_event_manager_allowance_get(860) > editing:0 clocklist_state:0 addviewer:0 scrolling:0 apptray-state:0 apptray-visibility:1 apptray-edit_visibility:0
05-31 10:59:55.670+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchPressed(1663) >  TOUCH [312, 211]
05-31 10:59:55.675+0700 E/W_HOME  (  970): util.c: util_is_rdu_retailmode(1530) > Cannot get the vconf for retailmode
05-31 10:59:55.675+0700 W/APPS    (  970): AppsViewNecklace.cpp: touchReleased(1976) >  TOUCH [312, 211]->[312, 211]
05-31 10:59:55.675+0700 W/APPS    (  970): AppsViewNecklace.cpp: runFocusAni(3491) >  nNewFocus[17], anim[1], autoLaunch[1], FocusNext[0], FocusPrev[0], FocusRecent[0], HideNextPage[0], ItemListSize[18]
05-31 10:59:55.675+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(478) >  onItemClicked[0,17]
05-31 10:59:55.675+0700 E/APPS    (  970): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
05-31 10:59:55.675+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(502) >  item(basicui) launched, open(0), tts(0)
05-31 10:59:55.685+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(org.example.basicui)
05-31 10:59:55.685+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:59:55.685+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:59:55.685+0700 I/AUL_AMD (  507): amd_launch.c: __check_app_control_privilege(1693) > Skip the privilege check in case of preloaded apps
05-31 10:59:55.695+0700 E/RESOURCED(  584): block.c: block_prelaunch_state(138) > insert data org.example.basicui, table num : 6
05-31 10:59:55.700+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(2218) > pad pid(-5)
05-31 10:59:55.700+0700 W/AUL_PAD ( 1260): launchpad.c: __launchpad_main_loop(611) > Launch on type-based process-pool
05-31 10:59:55.700+0700 W/AUL_PAD ( 1260): launchpad.c: __send_result_to_caller(272) > Check app launching
05-31 10:59:55.700+0700 W/AUL_PAD (20196): launchpad_loader.c: __candidate_process_prepare_exec(259) > [candidate] before __set_access
05-31 10:59:55.700+0700 W/AUL_PAD (20196): launchpad_loader.c: __candidate_process_prepare_exec(264) > [candidate] after __set_access
05-31 10:59:55.700+0700 W/AUL_PAD (20196): launchpad_loader.c: __candidate_process_launchpad_main_loop(414) > update argument
05-31 10:59:55.705+0700 W/AUL_PAD (20196): launchpad_loader.c: main(680) > [candidate] dlopen(org.example.basicui)
05-31 10:59:55.760+0700 I/efl-extension(20196): efl_extension.c: eext_mod_init(40) > Init
05-31 10:59:55.765+0700 I/UXT     (20196): Uxt_ObjectManager.cpp: OnInitialized(753) > Initialized.
05-31 10:59:55.765+0700 W/AUL_PAD (20196): launchpad_loader.c: main(690) > [candidate] dlsym
05-31 10:59:55.765+0700 W/AUL_PAD (20196): launchpad_loader.c: main(694) > [candidate] dl_main(org.example.basicui)
05-31 10:59:55.770+0700 I/CAPI_APPFW_APPLICATION(20196): app_main.c: ui_app_main(704) > app_efl_main
05-31 10:59:55.775+0700 I/CAPI_APPFW_APPLICATION(20196): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
05-31 10:59:55.800+0700 W/AUL     (  507): app_signal.c: aul_send_app_launch_request_signal(521) > aul_send_app_launch_request_signal app(org.example.basicui) pid(20196) type(uiapp) bg(0)
05-31 10:59:55.805+0700 W/AUL_AMD (  507): amd_status.c: __socket_monitor_cb(1277) > (20196) was created
05-31 10:59:55.805+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(20196)
05-31 10:59:55.805+0700 W/W_HOME  (  970): util.c: apps_util_launch_main_operation(785) > Launch app:[basicui] ret:[0]
05-31 10:59:55.805+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 10:59:55.810+0700 W/W_HOME  (  970): util.c: send_launch_appId(620) > launch appid[org.example.basicui]
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 10:59:55.810+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: IsPreloaded(395) > _MessagePortService::IsPreloaded
05-31 10:59:55.810+0700 W/STARTER (  711): pkg-monitor.c: _app_mgr_status_cb(400) > [_app_mgr_status_cb:400] Launch request [20196]
05-31 10:59:55.855+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:59:55.855+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:59:55.855+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-31 10:59:55.855+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(284) > _MessagePortService::SendMessage
05-31 10:59:55.860+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:59:55.860+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: SendMessage(292) > Sends a message to a remote message port [com.samsung.app-shortcut-widget:Apptray.Message.Launch.AppId]
05-31 10:59:55.860+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-31 10:59:55.860+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-31 10:59:55.860+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:59:55.860+0700 W/APPS    (  970): AppsItem.cpp: onItemClicked(536) >  appid(org.example.basicui)  pkgid(org.example.basicui), name(basicui)
05-31 10:59:55.890+0700 E/EFL     (20196): ecore_evas<20196> ecore_evas_extn.c:2204 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-31 10:59:55.910+0700 E/EFL     (20196): elementary<20196> elc_naviframe.c:2939 elm_naviframe_item_push() naviframe item push
05-31 10:59:55.950+0700 E/EFL     (20196): elementary<20196> elc_naviframe.c:2950 elm_naviframe_item_push() item(0x43b70850) will be pushed
05-31 10:59:55.960+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: item_badge_count(363) >  cannot get badge display
05-31 10:59:55.965+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: item_badge_count(368) >  cannot get badge count
05-31 10:59:55.980+0700 E/APP_SHORTCUT_WIDGET(13571): main.c: _setWidgetContentInfo(1582) >  0x45924078, org.example.collectpro|17|0 org.example.basicui|26|0 com.samsung.w-gallery|16|0 org.example.sensorapp|15|0 com.samsung.clocksetting|25|0 org.example.collectdata|14|0, 26
05-31 10:59:55.980+0700 I/CAPI_WIDGET_APPLICATION(13571): widget_app.c: __provider_update_cb(281) > received updating signal
05-31 10:59:55.995+0700 I/basicui (20196): started
05-31 10:59:56.010+0700 I/basicui (20196): started
05-31 10:59:56.015+0700 I/APP_CORE(20196): appcore-efl.c: __do_app(453) > [APP 20196] Event: RESET State: CREATED
05-31 10:59:56.015+0700 I/CAPI_APPFW_APPLICATION(20196): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
05-31 10:59:56.030+0700 I/APP_CORE(20196): appcore-efl.c: __do_app(522) > Legacy lifecycle: 0
05-31 10:59:56.030+0700 I/APP_CORE(20196): appcore-efl.c: __do_app(524) > [APP 20196] Initial Launching, call the resume_cb
05-31 10:59:56.030+0700 I/CAPI_APPFW_APPLICATION(20196): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
05-31 10:59:56.045+0700 W/W_HOME  (  970): event_manager.c: _ecore_x_message_cb(421) > state: 0 -> 1
05-31 10:59:56.045+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.045+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.045+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.045+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:56.045+0700 W/W_HOME  (  970): main.c: _ecore_x_message_cb(1029) > main_info.is_win_on_top: 0
05-31 10:59:56.045+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:56.050+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:56.070+0700 W/APP_CORE(20196): appcore-efl.c: __show_cb(860) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
05-31 10:59:56.090+0700 E/EFL     (  507): ecore_x<507> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18699197 button=1
05-31 10:59:56.120+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(460) > Window [0x1400003] is now visible(1)
05-31 10:59:56.120+0700 W/W_HOME  (  970): event_manager.c: _window_visibility_cb(470) > state: 1 -> 0
05-31 10:59:56.120+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.120+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:6, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.120+0700 W/W_HOME  (  970): main.c: _window_visibility_cb(996) > Window [0x1400003] is now visible(1)
05-31 10:59:56.120+0700 I/APP_CORE(20196): appcore-efl.c: __do_app(453) > [APP 20196] Event: RESUME State: RUNNING
05-31 10:59:56.125+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: PAUSE State: RUNNING
05-31 10:59:56.125+0700 I/CAPI_APPFW_APPLICATION(  970): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-31 10:59:56.125+0700 W/W_HOME  (  970): main.c: _appcore_pause_cb(489) > appcore pause
05-31 10:59:56.125+0700 W/W_HOME  (  970): event_manager.c: _app_pause_cb(390) > state: 1 -> 2
05-31 10:59:56.125+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.125+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.125+0700 W/W_HOME  (  970): event_manager.c: _state_control(176) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
05-31 10:59:56.125+0700 W/W_HOME  (  970): rotary.c: rotary_deattach(156) > rotary_deattach:0x46b6f488
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x46b6f488, elm_layout, func : 0x40059565
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x460c2aa8, elm_box, _activated_obj : 0x46b6f488, activated : 1
05-31 10:59:56.125+0700 I/efl-extension(  970): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
05-31 10:59:56.130+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(com.samsung.w-home) pid(970) status(bg) type(uiapp)
05-31 10:59:56.130+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[970] goes to (4)
05-31 10:59:56.130+0700 E/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(457) > [_proc_mgr_status_cb:457] >>>>H(pid 970)'s state(4)
05-31 10:59:56.135+0700 W/STARTER (  711): pkg-monitor.c: _proc_mgr_status_cb(455) > [_proc_mgr_status_cb:455] >> P[20196] goes to (3)
05-31 10:59:56.135+0700 W/AUL     (  507): app_signal.c: aul_send_app_status_change_signal(686) > aul_send_app_status_change_signal app(org.example.basicui) pid(20196) status(fg) type(uiapp)
05-31 10:59:56.150+0700 W/W_INDICATOR(  713): windicator.c: _home_screen_clock_visibility_changed_cb(1023) > [_home_screen_clock_visibility_changed_cb:1023] Clock visibility : 0
05-31 10:59:56.150+0700 W/APPS    (  970): AppsItem.cpp: setLastIndex(1280) >  This is last index app [17:basicui], focusIdx[17]
05-31 10:59:56.150+0700 W/APPS    (  970): AppsViewNecklace.cpp: __onSignalHideNextPage(7063) >  Hide next page [0->0]
05-31 10:59:56.150+0700 W/APPS    (  970): AppsItem.cpp: aniFocusIndex(2373) >  [basicui:17] Focused[0], focusIdx[17]
05-31 10:59:56.155+0700 W/W_HOME  (  970): win.c: win_back_gesture_disable_set(170) > disable back gesture
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(200) > _MessagePortService::CheckRemotePort
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: GetKey(358) > _MessagePortService::GetKey
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(213) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-31 10:59:56.155+0700 E/MESSAGE_PORT(  480): MessagePortService.cpp: CheckRemotePort(235) > _MessagePortService::CheckRemotePort() Failed: MESSAGEPORT_ERROR_MESSAGEPORT_NOT_FOUND
05-31 10:59:56.155+0700 I/MESSAGE_PORT(  480): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-31 10:59:56.160+0700 E/MESSAGE_PORT(  970): MessagePortProxy.cpp: CheckRemotePort(379) > The remote message port (music-control-service-request-message-port) is not found.
05-31 10:59:56.160+0700 W/W_HOME  (  970): clock_shortcut.c: _request_with_message_port(118) > remote port does not exist
05-31 10:59:56.160+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(284) > request cmd(0) to(com.samsung.w-music-player.music-control-service)
05-31 10:59:56.160+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 0
05-31 10:59:56.160+0700 W/W_INDICATOR(  713): windicator_battery.c: windicator_battery_vconfkey_unregister(595) > [windicator_battery_vconfkey_unregister:595] Unset battery cb
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_request.c: __request_handler(693) > no appinfo
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 9
05-31 10:59:56.160+0700 E/PKGMGR_INFO(  507): pkgmgrinfo_pkginfo.c: pkgmgrinfo_updateinfo_check_update(2501) > (pkgid == NULL) pkgid is NULL
05-31 10:59:56.160+0700 W/AUL     (  970): launch.c: app_request_to_launchpad(298) > request cmd(0) result(-13)
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 32
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 28
05-31 10:59:56.160+0700 E/CAPI_APPFW_APP_CONTROL(  970): app_control.c: app_control_error(138) > [app_control_send_launch_request] APP_NOT_FOUND(0xfef00021)
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 27
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_appinfo.c: appinfo_get_value(1269) > appinfo get value: Invalid argument, 31
05-31 10:59:56.160+0700 W/W_HOME  (  970): clock_shortcut.c: _mp_messageport_register(150) > err = fef00021
05-31 10:59:56.160+0700 W/AUL_AMD (  507): amd_launch.c: _start_app(1782) > caller pid : 970
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_launch.c: _start_app(1795) > no appinfo
05-31 10:59:56.160+0700 E/AUL_AMD (  507): amd_launch.c: __real_send(909) > send fail to client
05-31 10:59:56.160+0700 I/wnotib  (  970): w-notification-board-broker-main.c: _wnb_ecore_x_event_visibility_changed_cb(746) > fully_obscured: 1
05-31 10:59:56.160+0700 E/wnotib  (  970): w-notification-board-action.c: wnb_action_is_drawer_hidden(5192) > [NULL==g_wnb_action_data] msg Drawer not initialized.
05-31 10:59:56.160+0700 W/wnotib  (  970): w-notification-board-noti-manager.c: wnb_nm_postpone_updating_job(997) > Set is_notiboard_update_postponed to true with is_for_VI 0, notiboard panel creation count [8], notiboard card appending count [13].
05-31 10:59:56.190+0700 W/APPS    (  970): AppsViewNecklace.cpp: onPausedIdlerCb(5178) >  elm_cache_all_flush
05-31 10:59:56.230+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18699337 button=1
05-31 10:59:56.520+0700 E/TBM     (  461): tbm_bufmgr.c: _tgl_destroy(141) > [libtbm:461] error(Device or resource busy) _tgl_destroy:141 key:26
05-31 10:59:56.520+0700 E/AUL     (  507): app_signal.c: __app_dbus_signal_filter(97) > reject by security issue - no interface
05-31 10:59:56.660+0700 I/APP_CORE(  970): appcore-efl.c: __do_app(453) > [APP 970] Event: MEM_FLUSH State: PAUSED
05-31 10:59:56.875+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18699978 button=1
05-31 10:59:56.955+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18700059 button=1
05-31 10:59:57.005+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:59:57.015+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20196
05-31 10:59:57.015+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:59:57.060+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 14
05-31 10:59:57.065+0700 W/AUL_AMD (  507): amd_request.c: __send_result_to_client(91) > __send_result_to_client, pid: 20196
05-31 10:59:57.070+0700 W/AUL_AMD (  507): amd_request.c: __request_handler(669) > __request_handler: 12
05-31 10:59:57.245+0700 I/AUL_PAD (20352): launchpad_loader.c: main(591) > [candidate] elm init, returned: 1
05-31 10:59:57.955+0700 E/EFL     (  461): ecore_x<461> ecore_x_netwm.c:1520 ecore_x_netwm_ping_send() Send ECORE_X_ATOM_NET_WM_PING to client win:0x4600002 time=18700526
05-31 10:59:57.965+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:1958 _ecore_x_event_handle_client_message() Received ECORE_X_ATOM_NET_WM_PING, so send pong to root time=18700526
05-31 10:59:57.965+0700 E/EFL     (  461): ecore_x<461> ecore_x_events.c:1964 _ecore_x_event_handle_client_message() Received pong ECORE_X_ATOM_NET_WM_PING from client time=18700526
05-31 10:59:58.100+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:563 _ecore_x_event_handle_button_press() ButtonEvent:press time=18701195 button=1
05-31 10:59:58.200+0700 E/EFL     (20196): ecore_x<20196> ecore_x_events.c:722 _ecore_x_event_handle_button_release() ButtonEvent:release time=18701304 button=1
05-31 10:59:58.655+0700 I/MALI    (  970): egl_platform_x11_tizen.c: tizen_update_native_surface_private(194) > [EGL-X11] surface->[0x43ed95b8] swap changed from sync to async
05-31 10:59:58.675+0700 W/CRASH_MANAGER(20364): worker.c: worker_job(1205) > 1120196626173159089759
