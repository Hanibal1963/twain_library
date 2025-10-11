### Demo-Programme ###

Die Demo-Programme bestehen aus Visual Studio-2019-Projekten und einem Delphi-(Lazarus)-Projekt.  

Die Projekte sind C- und C++-Projekte, zusätzlich gibt es je ein C#-, Visual-Basic- und Delphi-Projekt. Das Delphi-Projekt wurde mit der <a href="https://www.lazarus-ide.org/" target="_blank">Lazarus Delphi</a>-Umgebung getestet.

----
### <a name="build-demo"></a> Erstellen der Demo-Anwendungen 
#### C++

Wenn Sie die C- und C++-Demoanwendungen erstellen möchten, kann die Datei **demos\AllDemos.sln** in Visual Studio 2019 oder 2022 geladen werden. Bitte beachten Sie, dass Sie zuerst die Basisbibliotheken erstellen müssen (durch Erstellen des oben erwähnten Projekts **dtwain_5_vs2019.sln**), bevor Sie die Demos bauen. Die Demos bestehen aus C- und C++-Beispielen sowie C++-Demos, die auf einer experimentellen C++-Wrapper-Bibliothek basieren, die derzeit entwickelt wird.

Beachten Sie, dass der C++-Wrapper standardmäßig **C++17** als Spracheinstellung verwendet, da der Wrapper verschiedene Typen und Klassen nutzt, die erst in C++17 oder höher vorhanden sind.

Es ist möglich, **C++14** zu verwenden; dies erfordert jedoch eine Installation der <a href="https://www.boost.org/" target="_blank">Boost-Bibliothek</a> (Version 1.70 oder höher). Die Umgebungsvariable **BOOST_INCLUDE_DIR** sollte definiert sein, bevor Visual Studio gestartet wird. Diese Variable muss auf das Wurzelverzeichnis zeigen, in dem sich die Boost-Headerdateien befinden. Beispiel:

SET BOOST_INCLUDE_DIR = c:\boost_installation

und das Verzeichnis c:\boost_installation sollte einen Ordner namens **boost** enthalten, der die Wurzel der Headerdateien darstellt.

----
#### C#

Die C#-Demo ist **demos\csharp\Examples\FullDemo\CSharp_FullDemo.csproj**  
Dieses Projekt ist standardmäßig für 32‑Bit-Unicode konfiguriert (die Datei dtwain32u.cs ist Teil des Projekts). Wenn Sie 64‑Bit-Builds ausprobieren möchten, ersetzen Sie bitte die dtwain32u.cs durch eine der 64‑Bit-.cs-Dateien (zum Beispiel dtwain64u.cs).

----
#### Visual Basic

Die Visual-Basic-Demo ist **demos\VisualBasic\Examples\FullDemo\VB_FullDemo.vbproj**  
Dieses Projekt ist standardmäßig für 32‑Bit-Unicode konfiguriert (die Datei dtwain32u.vb ist Teil des Projekts). Wenn Sie 64‑Bit-Builds ausprobieren möchten, ersetzen Sie bitte die dtwain32u.vb durch eine der 64‑Bit-.cs-Dateien (zum Beispiel dtwain64u.vb).

----
### Ausführen der Demos

1) Stellen Sie sicher, dass die [DTWAIN-DLLs](https://github.com/dynarithmic/twain_library/tree/master/binaries) verfügbar sind (System-PATH, Ihr EXE-Verzeichnis usw.), wenn das Demoprogramm startet, das Sie ausführen. Fehlt eine DLL, führt dies zur Laufzeit zu einem Fehler „Dynamic Link Library not found“.

2) Stellen Sie sicher, dass die Dateien aus <a href="https://github.com/dynarithmic/twain_library/tree/master/text_resources" target="_blank">text_resources</a> im selben Verzeichnis wie die DTWAIN-DLLs vorhanden sind. Fehlende Textressourcen führen zu einem Fehler „DTWAIN Resources not found“.

----
### Warum sind die Demo-Projekte nicht bereits vorab gebaut? Warum muss ich sie selbst erstellen?
Es hat sich herausgestellt, dass einige der ausführbaren Dateien, falls sie vorab gebaut werden, bei einigen wenigen Virenscannern Fehlalarme auslösen. Der Grund, warum Sie die Demo-Anwendungen selbst neu erstellen sollten, ist die Sicherheit, dass Sie keinen Virus ausführen (auch wenn es sich um einen Fehlalarm handelt).

Die DTWAIN-Bibliotheken selbst, dtwain32.dll, dtwain32u.dll usw., werden stets mit allen großen Virenscannern auf Fehlalarme überprüft (unter Verwendung von <a href="https://www.virustotal.com/gui/home/upload" target="_blank">Virus Total</a> als Referenz). Wenn eine der folgenden DLLs Probleme mit Fehlalarmen verursacht, beheben wir diese, bevor wir die DLLs im Master-Branch verfügbar machen.

* dtwain32.dll
* dtwain32u.dll
* dtwain32d.dll
* dtwain32ud.dll
* dtwain64.dll
* dtwain64u.dll
* dtwain64d.dll
* dtwain64ud.dll

Dateien, die mit **d** enden, zum Beispiel dtwain32d.dll, sind spezielle Debug-Versionen der DLL und sind im <a href="https://github.com/dynarithmic/twain_library_source/tree/main/binaries" target="_blank">twain_library_source-Repo</a> verfügbar.