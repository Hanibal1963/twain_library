### Wozu dient dieses Repository? ###

* Dieses Repository enthält die DTWAIN-Bibliothek, **Version 5.x**, von Dynarithmic Software. DTWAIN ist eine Open-Source-Programmierbibliothek, mit der Anwendungen Bilder von TWAIN?fähigen Geräten über eine einfache Application Programmer's Interface (API) erfassen können.

* Die Dynarithmic TWAIN Library ist Open Source und unter der Apache?2.0?Lizenz lizenziert. Bitte lesen Sie die Datei [LICENSE](https://github.com/dynarithmic/twain_library/tree/master/LICENSE) für weitere Informationen.
* Die Online-Hilfe zur DTWAIN-Bibliothek finden Sie [hier](https://www.dynarithmic.com/onlinehelp/dtwain/newversion/Dynarithmic%20TWAIN%20Library,%20Version%205.x.html) und im .CHM?Format (Windows-Hilfe) [hier](https://github.com/dynarithmic/twain_library-helpdocs/tree/main/windows).

    Die .CHM-Datei und die Online-Hilfe werden fortlaufend auf Version 5.x aktualisiert. Aktualisierungen stehen im [Hilferepository](https://github.com/dynarithmic/twain_library-helpdocs/tree/main) zur Verfügung, da dort ggf. Informationen zur älteren kommerziellen Version von DTWAIN enthalten sind, die aktualisiert oder entfernt werden müssen.
* Die aktuelle Version von DTWAIN ist [**5.7.0** (siehe Versionshistorie)](https://github.com/dynarithmic/twain_library/tree/master/updates/updates.txt).

**Bitte beachten Sie, dass der Quellcode und die Beispielprogramme für die Dynarithmic TWAIN Library in [dieses Repository](https://github.com/dynarithmic/twain_library_source/tree/main) verschoben wurden.**

----

### Ok, was ist diese Dynarithmic TWAIN-Bibliothek, oder „DTWAIN“, wie Sie sie nennen? ###

* Die Dynarithmic TWAIN Library (auch als DTWAIN bekannt) ist eine leistungsfähige Open-Source?Programmierbibliothek, mit der Sie die TWAIN?Bilderfassung von jedem TWAIN?Scanner oder jeder Digitalkamera einfach in Ihre Anwendungen integrieren können.

* DTWAIN ist als 32?Bit? und 64?Bit?Windows?DLL (Dynamic Link Library) implementiert. Zur Kommunikation mit der DLL werden exportierte Funktionen bereitgestellt. Dadurch kann jede Windows?Programmiersprache, die exportierte DLL?Funktionen direkt oder indirekt aufrufen kann, DTWAIN verwenden. Dazu gehören C, C++, C#, Visual Basic, Python, Delphi, Java, Ruby und zahlreiche weitere Sprachen.

* Wenn Sie mit dem TWAIN?Standard und der Bilderfassung von TWAIN?fähigen Geräten nicht vertraut sind, besuchen Sie bitte die offizielle TWAIN?Website unter [http://www.twain.org](http://www.twain.org) für weitere Informationen. Wenn Sie jemals einen Scanner gekauft oder verwendet und die Begriffe „TWAIN?konform“ oder „TWAIN?Treiber“ gesehen haben, sind Sie auf dem richtigen Weg. Wenn Sie daran interessiert sind, diese Geräte in Ihrer Anwendung in **C, C++, C#, Java, Visual Basic, Perl, Python, Ruby** (und anderen Sprachen) zu verwenden, sind Sie hier richtig.

* Die DTWAIN?Bibliothek nimmt Entwicklerinnen und Entwicklern die Details ab, Low?Level?Code gemäß der TWAIN?Spezifikation zu schreiben, um Bilder von einem TWAIN?Gerät abzurufen — ein paar Funktionsaufrufe zur Initialisierung und Erfassung der Bilder vom TWAIN?Gerät genügen.

(Es ist nichts dagegen einzuwenden, die TWAIN?Spezifikation zu verstehen, da dies Ihr Verständnis darüber verbessert, wie die DTWAIN?Bibliothek intern arbeitet. Allerdings macht die hohe Abstraktionsebene des TWAIN?Protokolls diese Bibliothek selbst für Einsteigerinnen und Einsteiger einfach nutzbar.)

----------
### Ist DTWAIN 5.x wirklich Open?Source?Software (OSS)?

* Die Dynarithmic® TWAIN Library wurde über 20 Jahre entwickelt und ist somit eine sehr ausgereifte Softwarekomponente. Wir haben diese Bibliothek in diesen Jahren als Closed?Source?Produkt kommerziell angeboten, uns jedoch entschieden, sie unter der Apache?2.0?Lizenz als Open Source zu veröffentlichen.

* Bitte beachten — da DTWAIN vor Version 5.0 in einigen Modulen Quellcode verwendete, der aus lizenzrechtlichen Gründen nicht allgemein veröffentlicht werden durfte, mussten wir diese Teile des Codes überarbeiten, um DTWAIN als Open?Source?Bibliothek anbieten zu können. Wir haben uns bemüht sicherzustellen, dass diese Änderungen keine Probleme verursachen, aber wie die meisten wissen, können Fehler existieren. Wenn Fehler gefunden werden, werden wir sie zeitnah beheben.

----------

### Voraussetzungen

DTWAIN wird unter *Windows 10 / Windows 11* für 32?Bit? und 64?Bit?Betriebssysteme unterstützt. Da die Basisbibliotheken für die Visual?C++?Laufzeitbibliothek ab Version 2015 gebaut sind, ist die minimal unterstützte Version der Visual?C++?Laufzeit **Visual C++ 2015**.

*Es gibt keinen offiziellen Support für Windows 7 / Windows 8.x, da neuere DTWAIN?Versionen nur für Windows 10 und 11 getestet werden. Das bedeutet nicht, dass DTWAIN unter Windows 7/8 nicht funktioniert, aber es wurde seit einigen Jahren nicht mehr für diese Betriebssysteme getestet. Wenn Sie Support für Windows 7 oder 8 benötigen, eröffnen Sie bitte ein [Issue](https://github.com/dynarithmic/twain_library/issues), um zu klären, ob dies berücksichtigt werden kann.*

----

Die „Standard“-Versionen der DTWAIN?Bibliothek (mit „Standard“ sind die DLLs in den Verzeichnissen **full_logging** und **partial_logging** gemeint — siehe unten im Abschnitt **Wie richte ich DTWAIN ein?**) erfordern keine Installation der Visual?C++?Runtime?Dateien, sodass es bei der Verwendung der Standardversionen diesbezüglich keine Probleme geben sollte. Allerdings sind die Standardversionen größer (bis zu etwa einem Megabyte) als die Versionen, die eine bereits installierte Visual?C++?Runtime auf dem System voraussetzen, auf dem DTWAIN ausgeführt wird.

Da die meisten Windows?Systeme in den vergangenen 8 Jahren die Visual?C++?Runtime durch andere Anwendungen bereits installiert haben, ist dies möglicherweise kein Problem und die kleineren DTWAIN?DLLs können verwendet werden. Falls auf Ihrem System dennoch die erforderlichen Laufzeitkomponenten fehlen, erhalten Sie die Visual?C++?Runtime?Bibliotheken <a href="https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170#latest-microsoft-visual-c-redistributable-version" target="_blank">hier</a>. Wählen Sie beim Download **vc_redist.x86.exe** für 32?Bit?Anwendungen und/oder **vc_redist.x64.exe** für 64?Bit?Anwendungen.

----------
### Ich habe kein TWAIN?Gerät oder keinen Scanner auf meinem System installiert. Wie kann ich mit DTWAIN arbeiten?
Es gibt Beispiel?TWAIN?Virtuellgeräte [hier](https://github.com/dynarithmic/twain_library/tree/master/SampleTWAINDevices). Nach der Installation stehen diese Geräte für die Bildakquise zur Auswahl, ähnlich wie ein installierter Scanner.

----------
----

### Wie richte ich DTWAIN ein? ###
----
**<u>Erstellen der DTWAIN?Anwendung</u>**

<a name="dtwaindllusage"></a>
Für 32?Bit?Anwendungen verwenden Sie die Binärdateien in **release_libraries.zip** in einem der folgenden Verzeichnisse:

[full_logging](https://github.com/dynarithmic/twain_library/tree/master/binaries/32bit/full_logging) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/32bit/full_logging/release_ziphashes32.txt)</br>
[partial_logging](https://github.com/dynarithmic/twain_library/tree/master/binaries/32bit/partial_logging) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/32bit/partial_logging/release_ziphashes32.txt)</br>
[full_logging_require_vcruntime](https://github.com/dynarithmic/twain_library/tree/master/binaries/32bit/full_logging_require_vcruntime) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/32bit/full_logging_require_vcruntime/release_ziphashes32.txt)</br>
[partial_logging_require_vcruntime](https://github.com/dynarithmic/twain_library/tree/master/binaries/32bit/partial_logging_require_vcruntime) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/32bit/partial_logging_require_vcruntime/release_ziphashes32.txt)</br>

----

Für 64?Bit?Anwendungen verwenden Sie die Binärdateien in **release_libraries.zip** in einem der folgenden Verzeichnisse:

[full_logging](https://github.com/dynarithmic/twain_library/tree/master/binaries/64bit/full_logging) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/64bit/full_logging/release_ziphashes64.txt)</br>
[partial_logging](https://github.com/dynarithmic/twain_library/tree/master/binaries/64bit/partial_logging) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/64bit/partial_logging/release_ziphashes64.txt)</br>
[full_logging_require_vcruntime](https://github.com/dynarithmic/twain_library/tree/master/binaries/64bit/full_logging_require_vcruntime) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/64bit/full_logging_require_vcruntime/release_ziphashes64.txt)</br>
[partial_logging_require_vcruntime](https://github.com/dynarithmic/twain_library/tree/master/binaries/64bit/partial_logging_require_vcruntime) mit Prüfsummen hier: [Prüfsummen](https://github.com/dynarithmic/twain_library/blob/master/binaries/64bit/partial_logging_require_vcruntime/release_ziphashes64.txt)</br>

----

Das Verzeichnis **full_logging** enthält DLLs mit folgenden Eigenschaften:
1) Mit vollständiger Protokollierung. Diese umfasst das Protokollieren von Call?Stack und Rückgabewerten beim Aufruf von DTWAIN?Funktionen sowie der Low?Level?Aufrufe, die DTWAIN an den TWAIN Data Source Manager sendet. Dies ist hilfreich, um Probleme beim Aufruf von DTWAIN zu erkennen.
2) Erfordert keine Installation der Visual?C++?Runtime auf dem Zielsystem.

Das Verzeichnis **partial_logging** enthält DLLs, die:
1) Ohne Protokollierung von Call?Stack und Rückgabewerten gebaut sind. Diese DLLs sind etwa 500 KB kleiner als die DLLs in **full_logging**. Direkte Aufrufe an den TWAIN?DSM auf niedriger Ebene sind enthalten, aber Call?Stack?/Rückgabewert?Protokollierung steht nicht zur Verfügung, und
2) Keine Installation der Visual?C++?Runtime auf dem Zielsystem erfordern.

Das Verzeichnis **full_logging_require_vcruntime** enthält DLLs, die
1) Mit vollständiger Protokollierung gebaut sind, genau wie oben unter **full_logging** beschrieben, und
2) Eine installierte Visual?C++?Runtime auf dem Zielsystem erfordern.

Das Verzeichnis **partial_logging_require_vcruntime** enthält DLLs, die
1) Ohne Protokollierung von Call?Stack und Rückgabewerten gebaut sind, genau wie oben unter **partial_logging** beschrieben, und
2) Eine installierte Visual?C++?Runtime auf dem Zielsystem erfordern.

Wenn Sie die Größe der DLLs nicht stört, sollten Sie die **full_logging**?DLLs verwenden. Wenn Sie kleinere DLLs bevorzugen und dafür auf Call?Stack?/Rückgabewert?Protokollierung verzichten können, verwenden Sie die **partial_logging**?DLLs.

Wenn Sie die Visual?C++?Runtime selbst installieren oder davon ausgehen, dass die Systeme, auf denen Sie DTWAIN ausführen, die Visual?C++?Runtime bereits installiert haben, können Sie die DLLs in den „*_require_vcruntime“-Verzeichnissen verwenden, um die Größe der verwendeten DTWAIN?DLLs weiter zu reduzieren.

Um zu unterscheiden, ob die DLLs mit vollständiger oder teilweiser Protokollierung verwendet werden (da die Namen der DTWAIN?DLLs selbst gleich sind, unabhängig davon, welche verwendet werden), siehe [folgende Information](https://github.com/dynarithmic/twain_library_source/tree/main/binaries/32bit#how-to-distinguish-between-full-and-partial-logging-dlls).

Zusätzlich sind die [Release?Versionen der Program Database (.PDB)?Dateien](https://github.com/dynarithmic/dtwain-pdb) verfügbar. Dies hilft beim Debuggen von DTWAIN?bezogenen Problemen.

----

Eine Aufschlüsselung der in **release_libraries.zip** enthaltenen Dateien:

    dtwain32.dll   --  32?Bit ANSI (MBCS) Dynamic Link Library
    dtwain32u.dll  --  32?Bit Unicode Dynamic Link Library
    dtwain32.lib   --  32?Bit ANSI (MBCS) Visual C++ Importbibliothek
    dtwain32u.lib  --  32?Bit Unicode Visual C++ Importbibliothek
    dtwain32.pdb   --  32?Bit PDB (Microsoft Debug) für dtwain32.dll
    dtwain32u.pdb  --  32?Bit PDB (Microsoft Debug) für dtwain32u.dll

    dtwain64.dll   --  64?Bit ANSI (MBCS) Dynamic Link Library
    dtwain64u.dll  --  64?Bit Unicode Dynamic Link Library
    dtwain64.lib   --  64?Bit ANSI (MBCS) Visual C++ Importbibliothek
    dtwain64u.lib  --  64?Bit Unicode Visual C++ Importbibliothek
    dtwain64.pdb   --  64?Bit PDB (Microsoft Debug) für dtwain64.dll
    dtwain64u.pdb  --  64?Bit PDB (Microsoft Debug) für dtwain64u.dll

###### Informationen für C? und C++?Programmierer:

Wenn Sie Visual C++ verwenden, stehen die Visual?C++?kompatiblen Importbibliotheken, die Sie zum Erstellen Ihrer 32?Bit? oder 64?Bit?Anwendung benötigen (Dateien mit der Endung *.lib), zur Verfügung.<br><br>
Wenn Sie nicht Visual C++ verwenden, sondern einen anderen C++?Compiler, siehe den [Abschnitt zur Nutzung zusätzlicher C++?Compiler](#alternatecompilers), um Importbibliotheks?Probleme zu vermeiden.

Sie müssen außerdem die Headerdateien aus dem Verzeichnis [c_cpp_includes](https://github.com/dynarithmic/twain_library/tree/master/c_cpp_includes) beim Erstellen Ihrer Anwendung einbinden. Ihr Build?**INCLUDE**?Pfad sollte auf diese Headerdateien verweisen.

Im Grunde müssen Sie Ihre Anwendung bauen und mit einer der Importbibliotheken verlinken, die der Zielumgebung Ihrer Anwendung entspricht. Entwickeln Sie z. B. eine 32?Bit?Unicode?Anwendung, verwenden Sie die Datei **dtwain32u.lib**, damit Ihre C/C++?Anwendung fehlerfrei gelinkt werden kann.

----
<a name="runningapplication"></a>
**<u>Ausführen der Anwendung</u>**

Nachdem Sie Ihre Anwendung erstellt haben, müssen Sie sicherstellen, dass sich die DTWAIN?DLL entweder irgendwo im Systempfad oder im Anwendungsverzeichnis befindet (es gibt weitere Orte, an denen die DLL liegen kann, das geht jedoch über diese Einführung hinaus — siehe:

[https://docs.microsoft.com/en-us/windows/desktop/dlls/dynamic-link-library-search-order](https://docs.microsoft.com/en-us/windows/desktop/dlls/dynamic-link-library-search-order)).

Zusätzlich zu den DLL?Dateien müssen die <a href="https://github.com/dynarithmic/twain_library/tree/master/text_resources/twaininfo.txt" target="_blank">Text?Ressourcendatei</a>, die <a href="https://github.com/dynarithmic/twain_library/blob/master/text_resources/dtwain32.ini" target="_blank">dtwain32.ini</a> für 32?Bit?Anwendungen und die <a href="https://github.com/dynarithmic/twain_library/blob/master/text_resources/dtwain64.ini" target="_blank">dtwain64.ini</a> für 64?Bit?Anwendungen</a> ebenfalls verfügbar sein (standardmäßig sollten diese Dateien im selben Verzeichnis wie die oben genannten DLLs liegen; seit Version **5.2.0.2** können diese Dateien im Verzeichnis liegen, das durch **DTWAIN_SetResourcePath** angegeben ist).

Wenn **twaininfo.txt** oder die INI?Dateien nicht gefunden werden, beschädigt sind, eine falsche Version haben oder ein anderes Problem vorliegt, das das Laden dieser Dateien verhindert, wird das folgende Meldungsfenster angezeigt, in dem eine oder mehrere Ursachen für den Fehler aufgeführt sind:

![following error when running your application](/images/resource_error.jpg)

Die Fehlermeldung unterscheidet sich je nach Ursache.

Hinweis: Wenn Ihre Anwendung das oben gezeigte Meldungsfenster unterdrücken, aber dennoch einen Fehler?Rückgabewert erhalten soll, verwenden Sie die API?Funktion **DTWAIN_SysInitializeNoBlocking** anstelle von **DTWAIN_SysInitialize** (siehe die Beispiele unten — ersetzen Sie einfach **DTWAIN_SysInitialize** durch **DTWAIN_SysInitializeNoBlocking**).

* Stellen Sie sicher, dass Sie die neueste Version von **twaininfo.txt** verwenden, da Änderungen an dieser Datei beeinflussen können, wie Ihre Anwendung mit zukünftigen DTWAIN?Versionen läuft. Am einfachsten stellen Sie dies sicher, indem Sie bei jeder neuen DTWAIN?DLL?Version auch die neueste **twaininfo.txt** verwenden.

DTWAIN führt intern eine Versionsprüfung der Ressourcen durch. Wenn DTWAIN feststellt, dass die Ressourcen beschädigt oder veraltet sind, gibt **DTWAIN_SysInitialize** einen NULL?Handle zurück, der auf einen Fehler hinweist.

Wenn **DTWAIN_SysInitialize** oder **DTWAIN_SysInitializeNoBlocking** 0 oder einen Null?Handle zurückgibt, sollten Sie **DTWAIN_GetLastError** aufrufen, um den Fehlerwert zu erhalten. Zusätzlich können Sie **DTWAIN_GetErrorString** mit der Fehlernummer aufrufen, um eine textuelle Fehlerbeschreibung zu erhalten.

----

Zusätzlich sind [optionale Zeichenketten?Ressourcendateien](https://github.com/dynarithmic/twain_library/tree/master-staging/additional_language_resources) verfügbar. Diese Dateien erlauben es, die Sprache anzupassen, die DTWAIN beim Protokollieren oder Melden von Fehlern verwendet. Beachten Sie, dass diese Dateien erst nach erfolgreicher Rückkehr von **DTWAIN_SysInitialize** oder **DTWAIN_SysInitializeNoBlocking** geladen werden.

Diese Dateien sollten im selben Verzeichnis wie die Datei **twaininfo.txt** und die INI?Dateien liegen.

Wenn Sie eine andere Ressourcendatei verwenden oder sogar Ihre eigene Sprachressource hinzufügen möchten, wird empfohlen, die betreffende Datei zu kopieren, umzubenennen, die erforderlichen Änderungen vorzunehmen und die neue Datei dann mit der API?Funktion **DTWAIN_LoadCustomStringResources** zu verwenden.

Ausführlichere Anweisungen zum Hinzufügen einer eigenen Ressourcendatei finden Sie <a href="https://github.com/dynarithmic/twain_library/tree/master/additional_language_resources" target="_blank">hier</a>.

----------
### Ok, wie sieht ein Codebeispiel aus?

Das einfachste Beispiel öffnet den TWAIN?Dialog „Quelle auswählen“, ermöglicht die Auswahl eines TWAIN?Geräts, erfasst anschließend ein Bild und speichert es als BMP?Datei mit dem Namen „Test.bmp“. Hier ein komplettes C++?Beispiel:
