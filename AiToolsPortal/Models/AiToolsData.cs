using System;
using System.Collections.Generic;
using System.Linq;

namespace AiToolsPortal.Models
{
    public static class AiToolsData
    {
        private static readonly List<AiToolItem> _tools = new List<AiToolItem>
        {
            new AiToolItem
            {
                Id = "notebooklm",
                Name = "Google NotebookLM",
                ShortTagline = "Grounded AI Research Assistant & Audio Overview Studio",
                OfficialUrl = "https://notebooklm.google.com/",
                Category = "Research & Writing",
                BadgeColor = "primary",
                IconClass = "bi-journal-bookmark-fill",
                OneParagraphDescription = "Google NotebookLM is an AI-powered personalized research assistant and interactive notebook built on Google's multimodal Gemini 1.5 Pro architecture that operates through source-grounded retrieval-augmented generation (RAG). Unlike generic chatbots that hallucinate or rely only on public web data, NotebookLM functions by ingesting your uploaded source materials—including PDFs, Google Docs, Google Slides, web URLs, YouTube video transcripts, and raw notes—synthesizing them within an extensive 1-million-token context window where every generated insight, summary, and answer is explicitly tethered to in-line citations pointing back to your original texts. It helps you digest dense documentation in minutes, extract key themes, organize research into structured study guides, FAQs, and briefing documents, generate custom mind maps, and transform complex material into engaging, podcast-style 'Audio Overviews' where two conversational AI hosts debate and explain the core concepts of your project, making it an indispensable productivity multiplier for students, researchers, analysts, and knowledge workers.",
                HowItWorksDetails = "Ingests user-supplied documents (PDFs, Docs, Slides, YouTube URLs, audio files) and builds a localized vector and semantic index within Gemini 1.5 Pro's 1M+ token window. Prompts are resolved strictly against these grounded sources, providing direct footnote citations and verifiable source links.",
                HowItHelpsDetails = "Eliminates cognitive overload by synthesizing hundreds of pages of technical specs, legal briefs, academic papers, or product manuals into immediate structured answers, interactive study guides, and studio-grade conversational audio podcasts.",
                KeyFeatures = new List<string>
                {
                    "Source Grounding & Inline Citations: Zero hallucination mode linked to your uploaded files.",
                    "Audio Overview (Deep Dive): Generates 10-15 minute conversational podcast discussions between two AI hosts.",
                    "Multimodal Source Ingestion: Supports PDFs, Google Docs, Google Slides, text files, web URLs, and YouTube videos.",
                    "1M+ Context Window: Upload dozens of full books, papers, or technical manuals simultaneously.",
                    "Interactive Study Studio: Automatically generates FAQs, Briefing Docs, Study Guides, Timelines, and Mind Maps."
                },
                PracticalUseCases = new List<string>
                {
                    "Synthesizing an entire semester of course notes or technical textbooks into exam flashcards and audio reviews.",
                    "Analyzing multi-party legal contracts, patent portfolios, or compliance disclosures with instant page citations.",
                    "Transforming product specification documents and meeting transcripts into executive summaries and roadmap plans."
                },
                SamplePrompt = "Based strictly on the uploaded system architecture specs, list all authentication protocols supported, cite the exact source sections, and draft a high-level briefing document for our security team.",
                YouTubeVideoId = "HqWm0mStCG8",
                YouTubeVideoTitle = "How to Use Google NotebookLM (Full Tutorial) - Kevin Stratvert"
            },
            new AiToolItem
            {
                Id = "stitch",
                Name = "Google Stitch",
                ShortTagline = "AI-Native Vibe Design & Prompt-to-UI Canvas",
                OfficialUrl = "https://stitch.withgoogle.com/",
                Category = "Design & UI/UX",
                BadgeColor = "info",
                IconClass = "bi-palette2",
                OneParagraphDescription = "Google Stitch is an experimental AI-native design canvas and rapid prototyping platform developed by Google Labs that translates natural language prompts, visual references, and sketches into production-ready UI/UX layouts and interactive frontend code. Operating through an intelligent design agent guided by 'vibe design' principles and multimodal foundation models, Stitch analyzes design intent, extracts color palettes, defines typography, generates responsive web and mobile components, and structures full user flows while maintaining design system consistency across multiple screens. It directly helps designers, product managers, and developers eliminate the tedious initial wireframing and mockup stages, allowing you to iterate rapidly on visual concepts, experiment with variant designs and interactive micro-states, and bridge the design-to-development handoff by exporting clean, production-grade frontend code (such as HTML/CSS, React, and Flutter) in minutes.",
                HowItWorksDetails = "Leverages multimodal AI agents that understand spatial design layouts, UI design systems, component hierarchies, and visual vibes. Users can prompt with natural language, mood boards, or screenshot references, and Stitch synthesizes vectorized screens, tokenized design systems, and frontend code.",
                HowItHelpsDetails = "Cuts app and website design ideation from weeks to minutes, letting entrepreneurs and software engineers prototype interactive mobile and web applications without waiting for dedicated design sprints or manual Figma wireframing.",
                KeyFeatures = new List<string>
                {
                    "Prompt-to-UI Canvas: Generates high-fidelity web and mobile screens from simple text briefs.",
                    "Vibe Design & Style Synthesis: Infuses specific visual vibes, color theories, and aesthetic directions seamlessly.",
                    "Multi-Screen User Flows: Builds coherent navigation sequences, onboarding funnels, and checkout flows.",
                    "Direct Code Export: Translates UI components directly into standard HTML/Tailwind, React, or Flutter code.",
                    "Interactive Variant Generation: Quickly generates alternative layouts, dark/light modes, and micro-states."
                },
                PracticalUseCases = new List<string>
                {
                    "Generating a 5-screen mobile onboarding flow for a fintech budgeting application based on a text prompt.",
                    "Rapidly mocking up a responsive SaaS dashboard landing page with dark mode and exporting the React code.",
                    "Iterating design variants with stakeholders during live pitch meetings to visualize product ideas on the fly."
                },
                SamplePrompt = "Design a clean, glassmorphic iOS mobile app screen for a crypto portfolio tracker with dark purple accent colors, real-time price trend cards, and a bottom navigation bar.",
                YouTubeVideoId = "o6Gr7X9erF8",
                YouTubeVideoTitle = "Google Stitch Tutorial for Beginners: Create AI UI Designs Step by Step"
            },
            new AiToolItem
            {
                Id = "aistudio",
                Name = "Google AI Studio",
                ShortTagline = "Rapid Prototyping & Gemini API Developer Playground",
                OfficialUrl = "https://aistudio.google.com",
                Category = "Developer & Prototyping",
                BadgeColor = "danger",
                IconClass = "bi-code-slash",
                OneParagraphDescription = "Google AI Studio is Google's web-based developer prototyping playground and rapid engineering environment for creating, testing, and fine-tuning applications with the cutting-edge Gemini model family (including Gemini 1.5 Flash and Gemini 1.5 Pro). It works by providing an intuitive interactive console where developers can configure system instructions, experiment with multimodal context (prompting with large video files, audio recordings, source code repositories, and high-resolution images), calibrate inference parameters like temperature and safety thresholds, test structured JSON schema outputs, and manage function calling and tool integrations. It helps developers and software engineers rapidly transition from initial prompt experimentation to full application deployment by providing immediate token metrics and latency evaluations, allowing one-click export of battle-tested prompts into runnable code snippets in Python, JavaScript, cURL, Kotlin, or Swift, and generating API keys for seamless integration into enterprise backend systems.",
                HowItWorksDetails = "Direct web interface to Google's Vertex and Gemini API backends. It provides chat prompts, freeform prompts, structured prompts, JSON mode enforcement, tool calling (function declarations), and live token counting across multimodal payloads of up to 2 million tokens.",
                HowItHelpsDetails = "Eliminates guesswork in LLM application architecture by letting developers test prompts against real-world video, audio, and code data, verify latency and token consumption, and immediately generate production-ready SDK code with an API key.",
                KeyFeatures = new List<string>
                {
                    "Gemini 1.5 Flash & Pro Access: Harness the fastest low-latency and most capable frontier models.",
                    "Multimodal Prompts: Upload 1-hour videos, audio files, full code repos, and PDFs directly in the prompt editor.",
                    "Structured Output (JSON Schema): Enforce strict JSON responses matching your application's data models.",
                    "Function Calling & Tool Declarations: Mock and test external API integrations and automated function execution.",
                    "One-Click Code Export: Instantly get runnable code in Python, JavaScript, cURL, Android Kotlin, and iOS Swift."
                },
                PracticalUseCases = new List<string>
                {
                    "Feeding a 45-minute technical presentation video to extract timestamped chapter summaries and slide outlines.",
                    "Prototyping a structured resume parser that extracts JSON entities matching an ATS database schema.",
                    "Testing complex system prompts with custom few-shot examples before deploying them to production microservices."
                },
                SamplePrompt = "You are an automated code reviewer. Analyze the attached C# ASP.NET controller for OWASP vulnerabilities and return a strictly validated JSON array containing line numbers, severity, and remediation code.",
                YouTubeVideoId = "IHOJUJjZbzc",
                YouTubeVideoTitle = "Google AI Studio for Beginners - Google Cloud Tech (Paige Bailey)"
            },
            new AiToolItem
            {
                Id = "wisprflow",
                Name = "Wispr Flow",
                ShortTagline = "AI Voice Dictation & Ambient Speech-to-Text Workflow",
                OfficialUrl = "https://wisprflow.ai/",
                Category = "Voice & Audio",
                BadgeColor = "warning",
                IconClass = "bi-mic-fill",
                OneParagraphDescription = "Wispr Flow is a next-generation AI-powered voice dictation and speech-to-text productivity application for desktop operating systems that enables users to write and dictate up to three times faster than typing across any text field or application. Powered by advanced Whisper-based automatic speech recognition models coupled with intelligent large language model post-processing, Flow listens to continuous, conversational speech in over 100 languages, actively strips out filler words (such as 'um', 'uh', and verbal stumbles), understands personalized jargon and custom vocabulary, automatically corrects grammar, and formats text contextually into complete sentences, bullet points, or email replies based on the target application. It empowers busy professionals, developers, executives, and writers to draft comprehensive emails, write code documentation, prompt AI models, and transcribe meeting thoughts effortlessly without touching the keyboard, dramatically cutting down typing fatigue while multiplying daily output.",
                HowItWorksDetails = "Runs as an ambient system tray background client on macOS and Windows. When triggered via hotkey, it captures audio through your microphone, performs low-latency neural acoustic transcription, and applies LLM context-formatting to paste pristine, grammatically polished text directly into whichever app has focus.",
                HowItHelpsDetails = "Saves hours of keyboard typing every single day, eliminates RSI/wrist strain, and lets you capture rapid streams of consciousness directly into Slack, Gmail, Google Docs, Notion, or IDEs at 150+ words per minute with auto-formatting.",
                KeyFeatures = new List<string>
                {
                    "3x Faster Than Typing: Effortlessly dictate at 150-180 words per minute into any application.",
                    "Smart Filler Word Removal: Automatically cleans up 'ums', 'ahs', repetitions, and self-corrections.",
                    "App-Context Formatting: Intelligently formats bullets for notes, formal paragraphs for emails, or Markdown for code.",
                    "Custom Vocabulary & Dictionary: Learns developer terms, company acronyms, project names, and teammates' names.",
                    "Global Multilingual Support: Dictate fluently across 100+ languages with automatic translation capabilities."
                },
                PracticalUseCases = new List<string>
                {
                    "Dictating long, thoughtful email replies and Slack messages while walking or leaning back from your desk.",
                    "Dictating detailed software architecture documentation, bug reports, and Git commit notes directly into VS Code.",
                    "Rapidly brain-dumping raw ideas, meeting debriefs, and strategic plans into Notion or Google Docs."
                },
                SamplePrompt = "[Spoken Voice Input]: 'Hey team comma just wanted to follow up on yesterday's sprint planning period. We need to make sure the database migrations are tested before deploy period.' -> Flow renders perfect corporate prose.",
                YouTubeVideoId = "NJPS-dsfcLs",
                YouTubeVideoTitle = "Wispr Flow Demo: AI Voice-to-Text in Gmail, Claude & Any App"
            },
            new AiToolItem
            {
                Id = "claude",
                Name = "Claude AI",
                ShortTagline = "State-of-the-Art Frontier Reasoning, Coding & Artifacts",
                OfficialUrl = "https://claude.ai/",
                Category = "General Intelligence",
                BadgeColor = "success",
                IconClass = "bi-chat-heart-fill",
                OneParagraphDescription = "Claude AI is Anthropic's flagship conversational artificial intelligence platform, powered by the industry-leading Claude 3.5 model family (featuring Claude 3.5 Sonnet, Haiku, and Opus) and engineered with Constitutional AI principles for superior safety, nuanced reasoning, and remarkably natural human-like prose. It works by analyzing user prompts across an expansive 200,000-token context window with cutting-edge visual reasoning, document parsing, and code generation capabilities, featuring a dedicated 'Artifacts' side-by-side workspace that renders interactive web apps, SVG graphics, React components, diagrams, and editable documents in real-time alongside the chat. Claude AI helps developers, researchers, writers, and knowledge workers tackle complex multi-step coding problems, debug architecture, analyze large-scale financial and legal documents, draft publication-ready content, and organize collaborative projects with persistent custom knowledge bases, providing an unmatched intellectual partner for demanding cognitive tasks.",
                HowItWorksDetails = "Trained via Constitutional AI and reinforcement learning with human feedback (RLHF) on massive multimodal corpora. Employs a dedicated dual-pane Artifacts UI that isolates code, SVGs, documents, and interactive React/HTML widgets so you can view, edit, and iterate on deliverables separately from the chat stream.",
                HowItHelpsDetails = "Dramatically accelerates programming, complex writing, and analytical tasks with human-level nuance, unmatched refactoring precision, and interactive live previews that let you test web applications and tools directly in your browser.",
                KeyFeatures = new List<string>
                {
                    "Claude 3.5 Sonnet Benchmark Leader: Top-tier performance in coding, reasoning, and visual interpretation.",
                    "Artifacts Dynamic Workspace: Live side-by-side preview and iteration of React apps, HTML/JS widgets, and documents.",
                    "200K Context Window: Ingest entire codebases, financial 10-K filings, research papers, or multiple books.",
                    "Projects & Custom Knowledge: Create project workspaces with specific reference documents and system instructions.",
                    "Superior Human Tone: Produces nuanced, thoughtful, non-generic prose without sycophancy or boilerplate filler."
                },
                PracticalUseCases = new List<string>
                {
                    "Building and live-previewing interactive Single Page Applications (SPAs) and React games inside the Artifact window.",
                    "Refactoring legacy monolith codebases, migrating architectures, and generating unit tests with high accuracy.",
                    "Performing deep qualitative analysis across complex policy documents, medical papers, or corporate filings."
                },
                SamplePrompt = "Build an interactive financial amortisation calculator in React with Tailwind CSS that lets the user adjust loan amount, interest rate, and term using sliders, and render the complete application in an Artifact.",
                YouTubeVideoId = "r2vYObllqJU",
                YouTubeVideoTitle = "Claude AI Tutorial for Beginners (Step-by-Step) - Kevin Stratvert"
            },
            new AiToolItem
            {
                Id = "julius",
                Name = "Julius AI",
                ShortTagline = "Conversational Data Science, Python Analytics & Visualizations",
                OfficialUrl = "https://julius.ai/",
                Category = "Data Science",
                BadgeColor = "secondary",
                IconClass = "bi-graph-up-arrow",
                OneParagraphDescription = "Julius AI is an intelligent data analysis and computational data science assistant that allows users to interact with complex datasets and perform statistical modeling using intuitive natural language prompts. It works by executing an underlying sandboxed Python and R runtime environment that ingests structured and unstructured data—including Excel spreadsheets, CSVs, Google Sheets, SQL databases, and PDFs—automatically generating clean data manipulation scripts, calculating descriptive and inferential statistics, running machine learning regressions, and rendering dynamic visualizations using libraries like Matplotlib, Seaborn, and Plotly. Julius AI helps data analysts, business intelligence specialists, researchers, and non-technical decision-makers bypass the friction of writing manual Pandas or SQL code, enabling you to detect anomalies, uncover predictive correlations, clean messy data tables, and generate presentation-ready analytical slides and executive reports in seconds.",
                HowItWorksDetails = "Upload your data file (CSV, XLSX, SQLite, etc.). Julius inspects schema, types, and summary distributions, translates your English instructions into Python/R scripts, executes them in a secure sandbox, inspects the programmatic output, and presents both the analytical conclusions and publication-grade charts.",
                HowItHelpsDetails = "Democratizes advanced data science: anyone can run clustering algorithms, ANOVA tests, cohort analyses, forecasting models, and interactive heatmaps without knowing Python syntax, SQL joins, or statistical notation.",
                KeyFeatures = new List<string>
                {
                    "Code-Backed Accurate Computation: Runs real Python and R scripts so calculations are mathematically exact.",
                    "Multi-Source Ingestion: Connects to Excel, CSV, Google Sheets, PostgreSQL, Snowflake, and PDF reports.",
                    "Interactive Visualizations: Generates publication-ready charts (scatter plots, heatmaps, sankey diagrams, box plots).",
                    "Automated Data Cleaning: Handles missing values, deduplication, date normalization, and type casting automatically.",
                    "AI Slide & Presentation Generator: Converts analytical findings and charts directly into downloadable slide decks."
                },
                PracticalUseCases = new List<string>
                {
                    "Uploading multi-year e-commerce sales CSVs to perform customer cohort retention analysis and churn forecasting.",
                    "Automating exploratory data analysis (EDA) on clinical survey results, calculating p-values and confidence intervals.",
                    "Transforming messy accounting spreadsheets into categorized expense dashboards and executive slide summaries."
                },
                SamplePrompt = "Load the attached Q3 sales spreadsheet. Clean any rows with null revenue, calculate month-over-month growth by product line, and produce a multi-bar chart comparing top 5 performing territories.",
                YouTubeVideoId = "pQFwcd-r-Pg",
                YouTubeVideoTitle = "How to Use Julius AI - Complete Data Analysis Tutorial"
            },
            new AiToolItem
            {
                Id = "higgsfield",
                Name = "Higgsfield AI",
                ShortTagline = "Cinematic AI Video Generation & Camera Motion Studio",
                OfficialUrl = "https://higgsfield.ai/",
                Category = "Video & Media",
                BadgeColor = "dark",
                IconClass = "bi-camera-reels-fill",
                OneParagraphDescription = "Higgsfield AI is a generative video creation and cinematic animation platform designed specifically for filmmakers, digital marketers, and visual creators who require precise control over character motion, visual aesthetics, and camera dynamics. Operating on proprietary video diffusion models and motion synthesis engines (such as the Seedance and Cinema Studio toolsets), Higgsfield processes text prompts and reference imagery to generate photorealistic video sequences while maintaining strict character facial consistency, subject continuity, and lifelike physical movement across scenes. It helps solo creators and production agencies overcome the chaotic unpredictability of conventional AI video generators by providing granular cinematic controls—such as custom camera pans, zooms, 3D tilts, crane shots, and prompt-driven lighting adjustments—drastically reducing production costs, streamlining social media ad production, and enabling full-fledged cinematic storytelling without costly physical cameras or studio sets.",
                HowItWorksDetails = "Combines proprietary generative video diffusion models with neural camera trajectory controls and character reference conditioning (Higgsfield Elements). Users define keyframes, camera motions (pan, tilt, zoom, dolly), and actor references to synthesize smooth, temporally consistent high-definition video clips.",
                HowItHelpsDetails = "Solves the biggest limitation in AI video—uncontrolled randomness and character face morphing—enabling content marketers and filmmakers to produce continuous, multi-shot commercial video ads and narrative films with persistent characters at a fraction of production budgets.",
                KeyFeatures = new List<string>
                {
                    "Cinema Studio Motion Controls: Direct camera movements like dolly zooms, crane shots, pans, and tracking shots.",
                    "Higgsfield Elements & Character Consistency: Preserve identical actor faces, clothes, and physical features across shots.",
                    "4K Upscaling & High Frame Rates: Delivers crisp, artifact-free video exports ready for commercial broadcast.",
                    "Seedance Video Diffusion Engines: State-of-the-art physics simulation, natural fabric movement, and facial expressions.",
                    "UGC Ad & Commercial Templates: Rapidly produce high-converting TikTok, Instagram Reel, and YouTube ad creatives."
                },
                PracticalUseCases = new List<string>
                {
                    "Creating a photorealistic 30-second commercial for a luxury watch brand with continuous cinematic camera pans.",
                    "Directing an independent sci-fi short film with persistent character actors across interior and exterior scenes.",
                    "Generating batches of high-converting social media UGC video ads featuring synthetic influencers."
                },
                SamplePrompt = "Cinematic 4K medium shot of a female cyber-detective walking down a neon-lit rain-slicked Tokyo alley, camera smoothly dollying backward at eye level, anamorphic lens flare, photorealistic facial details.",
                YouTubeVideoId = "CVzfQuC0aMU",
                YouTubeVideoTitle = "Higgsfield AI Video Generation & Cinema Walkthrough"
            },
            new AiToolItem
            {
                Id = "claudeskills",
                Name = "Claude Skills",
                ShortTagline = "Modular Agentic Competencies & Repeatable Task Workflows",
                OfficialUrl = "https://claude.com/skills",
                Category = "Developer & Prototyping",
                BadgeColor = "primary",
                IconClass = "bi-tools",
                OneParagraphDescription = "Claude Skills (also known as Agent Skills) represent Anthropic's open, modular framework that equips Claude with specialized, repeatable domain competencies and autonomous execution capabilities across Claude.ai, Claude Code, and the Claude API. Built around structured packages containing a SKILL.md instruction specification, executable scripts, and contextual assets, the framework employs a progressive disclosure mechanism where Claude initially consumes minimal token overhead and dynamically retrieves in-depth workflow instructions, schema definitions, and local tools only when a task demands it. Claude Skills help developers and enterprise teams transform conversational AI into a deterministic agentic collaborator that enforces organizational brand guidelines, executes multi-step code refactoring across massive repositories, automates document pipelines (like formatting Word, Excel, and PowerPoint decks), and integrates with external Model Context Protocol (MCP) servers to perform complex, automated end-to-end workflows reliably.",
                HowItWorksDetails = "Skills are organized in folders with a SKILL.md file featuring YAML metadata (name, description, trigger conditions) and instructions. Claude loads only the lightweight skill index into memory initially, activating the full skill scripts, rules, and toolsets only when the user's intent matches the trigger schema.",
                HowItHelpsDetails = "Prevents context window bloat and instruction dilution. Instead of repeatedly pasting 500-word prompt guidelines into every chat session, you encapsulate instructions, scripts, and validation steps once into a reusable skill that executes consistently every time.",
                KeyFeatures = new List<string>
                {
                    "Progressive Context Disclosure: Minimizes token consumption by loading deep instructions only on demand.",
                    "Modular SKILL.md Standard: Open, human-readable specification with YAML metadata and structured instructions.",
                    "Tool & Script Orchestration: Bundles executable Python/Bash scripts, schemas, and templates alongside AI guidelines.",
                    "MCP Integration: Bridges skills with Model Context Protocol servers for database, cloud, and filesystem access.",
                    "Enterprise Consistency: Enforces strict coding conventions, compliance checks, and corporate document standards."
                },
                PracticalUseCases = new List<string>
                {
                    "Packaging an enterprise brand guideline skill that enforces exact color schemes, fonts, and tone across all decks.",
                    "Creating a database migration skill for Claude Code that inspects entity models, drafts migrations, and verifies tests.",
                    "Automating complex legal contract reviews by packaging clause checklists and risk evaluation criteria into a skill."
                },
                SamplePrompt = "Invoke the 'doc-generator' skill to inspect the project repository, extract all public API interfaces, and generate an interactive Markdown reference document matching our internal engineering handbook.",
                YouTubeVideoId = "kS1MJFZWMq4",
                YouTubeVideoTitle = "Anthropic Claude Skill-Creator & Agent Skills Demo"
            },
            new AiToolItem
            {
                Id = "elevenlabs",
                Name = "ElevenLabs",
                ShortTagline = "Hyper-Realistic Voice AI, Voice Cloning & Sound Effects Studio",
                OfficialUrl = "https://elevenlabs.io/",
                Category = "Voice & Audio",
                BadgeColor = "danger",
                IconClass = "bi-soundwave",
                OneParagraphDescription = "ElevenLabs is an industry-leading voice AI and synthetic speech generation platform that produces hyper-realistic, emotionally nuanced human speech, voice cloning, and audio sound effects across dozens of languages. Operating through deep learning neural networks and latent diffusion models trained on phonetic dynamics and emotional prosody, ElevenLabs analyzes text syntax and semantic sentiment to render natural pacing, breathing pauses, cadence variations, and tonal inflection that are indistinguishable from professional voice actors. It helps content creators, game developers, video producers, podcasters, and software engineers generate lifelike voiceovers, create instant or professional digital voice clones with minutes of audio, localize videos into over 30 languages with automatic lip-sync dubbing, produce ambient foley sound effects, and deploy conversational low-latency AI voice agents for automated customer service.",
                HowItWorksDetails = "Employs neural acoustic models and deep latent diffusion architectures that predict both the acoustic spectral features and the micro-prosody (pitch variation, breathing, cadence, emotion) of human speech from text, supporting both Instant Voice Cloning (from 1 minute of audio) and Professional Voice Cloning (PVC).",
                HowItHelpsDetails = "Eliminates the enormous time, equipment costs, and logistical hurdles of hiring professional voice actors or setting up recording studios, enabling instant creation of studio-grade narrations, multilingual dubs, game character voices, and interactive conversational voicebots.",
                KeyFeatures = new List<string>
                {
                    "Emotionally Nuanced Text-to-Speech: Uncanny human realism with customizable stability, clarity, and style exaggeration.",
                    "Instant & Professional Voice Cloning: Replicate any voice with high fidelity from a sample audio file.",
                    "Automated Video Dubbing & Lip Sync: Translate video audio into 30+ languages while preserving the speaker's original voice.",
                    "Text-to-Sound Effects: Generate custom foley effects, cinematic impacts, and ambient backgrounds from text prompts.",
                    "Conversational AI Agents: Ultra-low latency (<500ms) voice agents for phone calls, support bots, and gaming NPCs."
                },
                PracticalUseCases = new List<string>
                {
                    "Narrating full-length audiobooks and long-form YouTube documentary scripts with natural pacing and emotion.",
                    "Dubbing English instructional videos into Spanish, Japanese, and German while keeping the instructor's original voice.",
                    "Building low-latency conversational voice customer service bots integrated via the ElevenLabs WebSocket API."
                },
                SamplePrompt = "Synthesize an enthusiastic, warm documentary narrator voice: 'In the heart of the digital revolution, artificial intelligence is transforming how humanity creates, communicates, and envisions the future.'",
                YouTubeVideoId = "yDTbAxJ3sKI",
                YouTubeVideoTitle = "How to Use ElevenLabs AI - Voiceover & Voice Cloning Tutorial (Kevin Stratvert)"
            }
        };

        public static List<AiToolItem> GetAllTools()
        {
            return _tools;
        }

        public static AiToolItem GetToolById(string id)
        {
            if (string.IsNullOrWhiteSpace(id)) return null;
            return _tools.FirstOrDefault(t => t.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static List<string> GetCategories()
        {
            return _tools.Select(t => t.Category).Distinct().ToList();
        }
    }
}
