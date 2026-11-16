# AI Nexus Intelligence Portal (ASP.NET MVC .NET Framework 4.8)

A professional, responsive C# ASP.NET MVC (.NET Framework 4.8) web application providing comprehensive intelligence on 9 cutting-edge AI tools. Features a modern multi-tab interface, responsive 16:9 embedded YouTube video walkthroughs, and categorized research guides.

---

## 🚀 Quick Start: How to Run the Application

You can launch the web application using any of the following 3 methods:

### Option 1: One-Click Windows Batch Script
Double-click `run.bat` in the project root (or inside `AiToolsPortal\`):
```cmd
run.bat
```
This automatically starts IIS Express on `http://localhost:5050` and opens it in your default browser.

### Option 2: PowerShell Launcher
Right-click `Run-AiToolsPortal.ps1` and select **Run with PowerShell** (or run from a terminal):
```powershell
.\Run-AiToolsPortal.ps1
```

### Option 3: Visual Studio
1. Double-click `AiToolsPortal.sln` to open the solution in Visual Studio.
2. The project is pre-configured with the **Web Application Profile** (`UseIISExpress: True`, port `5050`).
3. Press **F5** (Debug) or **Ctrl+F5** (Start Without Debugging) to launch.

---

## 🛠 Project Structure & Technology Stack

- **Framework:** Microsoft .NET Framework 4.8
- **Architecture:** ASP.NET MVC 5 (Model-View-Controller)
- **View Engine:** Razor (`.cshtml`)
- **Styling:** Bootstrap 5.3 + Custom Modern Glassmorphic CSS (`Content/css/styles.css`)
- **Icons:** Bootstrap Icons (`bi-*`)
- **Client Scripting:** JavaScript ES6 (`Scripts/app.js`) with live search, category filtering, tab switching, and dark/light theme persistence
- **Media:** Responsive 16:9 embedded YouTube video players with lazy loading

```
c:\antigravity\
├── AiToolsPortal.sln             # Visual Studio Solution (Web Application profile)
├── run.bat                       # 1-Click Batch launcher
├── Run-AiToolsPortal.ps1         # PowerShell launcher
├── README.md                     # Documentation
└── AiToolsPortal/
    ├── AiToolsPortal.csproj      # ASP.NET MVC 5 Web Application Project File
    ├── packages.config           # NuGet packages manifest
    ├── Web.config                # Root IIS configuration, handlers & binding redirects
    ├── Global.asax               # Application lifecycle & routing registration
    ├── Global.asax.cs            # Codebehind for application start & routing
    ├── run.bat                   # Local folder launcher
    ├── Run-AiToolsPortal.ps1     # Local PowerShell launcher
    ├── App_Start/
    │   └── RouteConfig.cs        # Route mappings (Home/Index, tool/{id})
    ├── Controllers/
    │   └── HomeController.cs     # Index, Detail, and About actions
    ├── Models/
    │   ├── AiToolItem.cs         # Core tool data model & view model
    │   └── AiToolsData.cs        # 9 AI tools repository & metadata
    ├── Properties/
    │   └── AssemblyInfo.cs       # Assembly metadata & GUID
    ├── Views/
    │   ├── Web.config            # Razor view configuration
    │   ├── _ViewStart.cshtml     # Layout configuration
    │   ├── Shared/
    │   │   └── _Layout.cshtml    # Master responsive layout with theme switcher
    │   └── Home/
    │       ├── Index.cshtml      # Multi-tab layout (Overview, 9 Tool Tabs, Matrix)
    │       ├── Detail.cshtml     # Dedicated standalone tool view
    │       └── About.cshtml      # System architecture & documentation
    ├── Content/
    │   └── css/styles.css        # Custom responsive styles, badges & animations
    └── Scripts/
        └── app.js                # Tabs, search, category filters & clipboard
```

---

## 🌟 The 9 Curated AI Tools (Details & One-Paragraph Descriptions)

### 1. Google NotebookLM
- **Official URL:** [https://notebooklm.google.com/](https://notebooklm.google.com/)
- **Category:** Research & Writing
- **YouTube Embed:** [How to Use Google NotebookLM (Kevin Stratvert)](https://www.youtube.com/watch?v=HqWm0mStCG8)
- **1-Paragraph Description:**
  > Google NotebookLM is an AI-powered personalized research assistant and interactive notebook built on Google's multimodal Gemini 1.5 Pro architecture that operates through source-grounded retrieval-augmented generation (RAG). Unlike generic chatbots that hallucinate or rely only on public web data, NotebookLM functions by ingesting your uploaded source materials—including PDFs, Google Docs, Google Slides, web URLs, YouTube video transcripts, and raw notes—synthesizing them within an extensive 1-million-token context window where every generated insight, summary, and answer is explicitly tethered to in-line citations pointing back to your original texts. It helps you digest dense documentation in minutes, extract key themes, organize research into structured study guides, FAQs, and briefing documents, generate custom mind maps, and transform complex material into engaging, podcast-style "Audio Overviews" where two conversational AI hosts debate and explain the core concepts of your project, making it an indispensable productivity multiplier for students, researchers, analysts, and knowledge workers.

---

### 2. Google Stitch
- **Official URL:** [https://stitch.withgoogle.com/](https://stitch.withgoogle.com/)
- **Category:** Design & UI/UX
- **YouTube Embed:** [Google Stitch Tutorial for Beginners](https://www.youtube.com/watch?v=o6Gr7X9erF8)
- **1-Paragraph Description:**
  > Google Stitch is an experimental AI-native design canvas and rapid prototyping platform developed by Google Labs that translates natural language prompts, visual references, and sketches into production-ready UI/UX layouts and interactive frontend code. Operating through an intelligent design agent guided by "vibe design" principles and multimodal foundation models, Stitch analyzes design intent, extracts color palettes, defines typography, generates responsive web and mobile components, and structures full user flows while maintaining design system consistency across multiple screens. It directly helps designers, product managers, and developers eliminate the tedious initial wireframing and mockup stages, allowing you to iterate rapidly on visual concepts, experiment with variant designs and interactive micro-states, and bridge the design-to-development handoff by exporting clean, production-grade frontend code (such as HTML/CSS, React, and Flutter) in minutes.

---

### 3. Google AI Studio
- **Official URL:** [https://aistudio.google.com](https://aistudio.google.com)
- **Category:** Developer & Prototyping
- **YouTube Embed:** [Google AI Studio for Beginners (Paige Bailey)](https://www.youtube.com/watch?v=IHOJUJjZbzc)
- **1-Paragraph Description:**
  > Google AI Studio is Google's web-based developer prototyping playground and rapid engineering environment for creating, testing, and fine-tuning applications with the cutting-edge Gemini model family (including Gemini 1.5 Flash and Gemini 1.5 Pro). It works by providing an intuitive interactive console where developers can configure system instructions, experiment with multimodal context (prompting with large video files, audio recordings, source code repositories, and high-resolution images), calibrate inference parameters like temperature and safety thresholds, test structured JSON schema outputs, and manage function calling and tool integrations. It helps developers and software engineers rapidly transition from initial prompt experimentation to full application deployment by providing immediate token metrics and latency evaluations, allowing one-click export of battle-tested prompts into runnable code snippets in Python, JavaScript, cURL, Kotlin, or Swift, and generating API keys for seamless integration into enterprise backend systems.

---

### 4. Wispr Flow
- **Official URL:** [https://wisprflow.ai/](https://wisprflow.ai/)
- **Category:** Voice & Audio
- **YouTube Embed:** [Wispr Flow Voice Dictation Demo](https://www.youtube.com/watch?v=NJPS-dsfcLs)
- **1-Paragraph Description:**
  > Wispr Flow is a next-generation AI-powered voice dictation and speech-to-text productivity application for desktop operating systems that enables users to write and dictate up to three times faster than typing across any text field or application. Powered by advanced Whisper-based automatic speech recognition models coupled with intelligent large language model post-processing, Flow listens to continuous, conversational speech in over 100 languages, actively strips out filler words (such as "um", "uh", and verbal stumbles), understands personalized jargon and custom vocabulary, automatically corrects grammar, and formats text contextually into complete sentences, bullet points, or email replies based on the target application. It empowers busy professionals, developers, executives, and writers to draft comprehensive emails, write code documentation, prompt AI models, and transcribe meeting thoughts effortlessly without touching the keyboard, dramatically cutting down typing fatigue while multiplying daily output.

---

### 5. Claude AI
- **Official URL:** [https://claude.ai/](https://claude.ai/)
- **Category:** General Intelligence & Coding
- **YouTube Embed:** [Claude AI Tutorial for Beginners (Kevin Stratvert)](https://www.youtube.com/watch?v=r2vYObllqJU)
- **1-Paragraph Description:**
  > Claude AI is Anthropic’s flagship conversational artificial intelligence platform, powered by the industry-leading Claude 3.5 model family (featuring Claude 3.5 Sonnet, Haiku, and Opus) and engineered with Constitutional AI principles for superior safety, nuanced reasoning, and remarkably natural human-like prose. It works by analyzing user prompts across an expansive 200,000-token context window with cutting-edge visual reasoning, document parsing, and code generation capabilities, featuring a dedicated "Artifacts" side-by-side workspace that renders interactive web apps, SVG graphics, React components, diagrams, and editable documents in real-time alongside the chat. Claude AI helps developers, researchers, writers, and knowledge workers tackle complex multi-step coding problems, debug architecture, analyze large-scale financial and legal documents, draft publication-ready content, and organize collaborative projects with persistent custom knowledge bases, providing an unmatched intellectual partner for demanding cognitive tasks.

---

### 6. Julius AI
- **Official URL:** [https://julius.ai/](https://julius.ai/)
- **Category:** Data Science & Analytics
- **YouTube Embed:** [How to Use Julius AI - Complete Data Analysis Tutorial](https://www.youtube.com/watch?v=pQFwcd-r-Pg)
- **1-Paragraph Description:**
  > Julius AI is an intelligent data analysis and computational data science assistant that allows users to interact with complex datasets and perform statistical modeling using intuitive natural language prompts. It works by executing an underlying sandboxed Python and R runtime environment that ingests structured and unstructured data—including Excel spreadsheets, CSVs, Google Sheets, SQL databases, and PDFs—automatically generating clean data manipulation scripts, calculating descriptive and inferential statistics, running machine learning regressions, and rendering dynamic visualizations using libraries like Matplotlib, Seaborn, and Plotly. Julius AI helps data analysts, business intelligence specialists, researchers, and non-technical decision-makers bypass the friction of writing manual Pandas or SQL code, enabling you to detect anomalies, uncover predictive correlations, clean messy data tables, and generate presentation-ready analytical slides and executive reports in seconds.

---

### 7. Higgsfield AI
- **Official URL:** [https://higgsfield.ai/](https://higgsfield.ai/)
- **Category:** Video & Media Generation
- **YouTube Embed:** [Higgsfield AI Video Generation & Cinema Walkthrough](https://www.youtube.com/watch?v=CVzfQuC0aMU)
- **1-Paragraph Description:**
  > Higgsfield AI is a generative video creation and cinematic animation platform designed specifically for filmmakers, digital marketers, and visual creators who require precise control over character motion, visual aesthetics, and camera dynamics. Operating on proprietary video diffusion models and motion synthesis engines (such as the Seedance and Cinema Studio toolsets), Higgsfield processes text prompts and reference imagery to generate photorealistic video sequences while maintaining strict character facial consistency, subject continuity, and lifelike physical movement across scenes. It helps solo creators and production agencies overcome the chaotic unpredictability of conventional AI video generators by providing granular cinematic controls—such as custom camera pans, zooms, 3D tilts, crane shots, and prompt-driven lighting adjustments—drastically reducing production costs, streamlining social media ad production, and enabling full-fledged cinematic storytelling without costly physical cameras or studio sets.

---

### 8. Claude Skills
- **Official URL:** [https://claude.com/skills](https://claude.com/skills)
- **Category:** Developer & Agentic Workflows
- **YouTube Embed:** [Anthropic Claude Skill-Creator & Agent Skills Demo](https://www.youtube.com/watch?v=kS1MJFZWMq4)
- **1-Paragraph Description:**
  > Claude Skills (also known as Agent Skills) represent Anthropic’s open, modular framework that equips Claude with specialized, repeatable domain competencies and autonomous execution capabilities across Claude.ai, Claude Code, and the Claude API. Built around structured packages containing a SKILL.md instruction specification, executable scripts, and contextual assets, the framework employs a progressive disclosure mechanism where Claude initially consumes minimal token overhead and dynamically retrieves in-depth workflow instructions, schema definitions, and local tools only when a task demands it. Claude Skills help developers and enterprise teams transform conversational AI into a deterministic agentic collaborator that enforces organizational brand guidelines, executes multi-step code refactoring across massive repositories, automates document pipelines (like formatting Word, Excel, and PowerPoint decks), and integrates with external Model Context Protocol (MCP) servers to perform complex, automated end-to-end workflows reliably.

---

### 9. ElevenLabs
- **Official URL:** [https://elevenlabs.io/](https://elevenlabs.io/)
- **Category:** Voice & Audio Synthesis
- **YouTube Embed:** [How to Use ElevenLabs AI - Voiceover & Voice Cloning (Kevin Stratvert)](https://www.youtube.com/watch?v=yDTbAxJ3sKI)
- **1-Paragraph Description:**
  > ElevenLabs is an industry-leading voice AI and synthetic speech generation platform that produces hyper-realistic, emotionally nuanced human speech, voice cloning, and audio sound effects across dozens of languages. Operating through deep learning neural networks and latent diffusion models trained on phonetic dynamics and emotional prosody, ElevenLabs analyzes text syntax and semantic sentiment to render natural pacing, breathing pauses, cadence variations, and tonal inflection that are indistinguishable from professional voice actors. It helps content creators, game developers, video producers, podcasters, and software engineers generate lifelike voiceovers, create instant or professional digital voice clones with minutes of audio, localize videos into over 30 languages with automatic lip-sync dubbing, produce ambient foley sound effects, and deploy conversational low-latency AI voice agents for automated customer service.
