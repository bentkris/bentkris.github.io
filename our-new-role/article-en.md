# Developers! *What is our role now* when coding is solved?

*Three decades of evolution — one year of revolution*

---

Long before my time, developers sat feeding computers with punched cards — physical cards with holes representing instructions. Each row was a command. Wrong hole, wrong program. The next generation moved to assembler: cryptic but precise instructions directly to the processor. `MOV`, `ADD`, `JMP` — one step at a time, in the machine's own language.

When I studied computer engineering in the late 1990s, we learned assembler for a brief semester. It already felt like a look back — something you should have seen, but not something you'd want to return to. We had high-level languages, object orientation and abstraction. Yet something important stuck: **the core of what we do has always been about giving precise instructions.** The format has changed — from holes in cardboard, through machine code and programming languages, to today's natural language with AI agents — but the demand for precision and intent has never gone away.

Over the course of nearly three decades as a software developer, I have experienced a steady, continuous improvement in how we build software and systems. We have moved from manual processes, Word-based deployment instructions and waterfall with requirements specifications and releases every six months. Then came Agile, DevOps, cloud platforms, containers and infrastructure as code. For a long time this was an evolution — a slow but steady shift towards more automation and better collaboration.

When I moved from a traditional developer role to also working with infrastructure and operations in 2012, during the "DevOps decade", I got my first digital colleague. Back then it wasn't an instructed AI agent, but PowerShell. Everything that had been manual — configurations and routines — was to be automated. From server setup to rolling deployment. Little did I know that I would soon get digital helpers — with "superpowers"!

## Everything has changed in the last couple of years — fast!

*Progress was steady for many years. Then the curve went steep.*

About two years ago, my team and I started testing GitHub Copilot — cautiously, in "ask mode". It didn't seem likely that GitHub Copilot could contribute much — after all, we have many years of experience writing good code ourselves. But quite quickly we saw that it covered everything we used to get from documentation, Google and Stack Overflow. Although we noticed it could introduce errors and confusion in early versions, it has become much better just in the first part of 2026. Without really thinking about it, AI tools are used more and more, as a natural part of problem solving, maintenance and feature work.

From autumn 2025, agents arrived in full force: AI tools that don't just suggest code, but plan, write, test and refactor — across files and contexts. The productivity increase is no longer linear, but exponential. Where are we now?

> We practically no longer write code ourselves. What started gradually, as tool support, is now our new way of working.

## Quality and maintainability

Technical debt is a familiar topic. The good news is that agents neither procrastinate nor dread tackling it. They do, of course, need clear instructions — humans must still understand and prioritise the need and set the direction.

Do you recognise the feeling of uncertainty when you need to modify legacy code, written by someone who left five years ago? Code that "nobody dares to touch"? With today's AI tools, it's less daunting. The key lies in the approach:

> It's tempting to instruct: "Rewrite this old crappy code!"
> But a better approach is: "Start by writing tests that make it easier to understand what this code actually does."

Once the agent has established the tests, it's much safer to proceed with refactoring, cleanup and framework upgrades. And in the best case, you find unused functions or entire modules that can be deleted — joy!

## Claude Code — this changes everything

After gradually increasing my use of AI tools for maintaining, problem solving and building on existing codebases, and growing buzz in tech and IT media and among colleagues, I wanted to try building something with AI in my spare time. From scratch, without the natural constraints of an enterprise environment.

After just a few hours hands-on with Claude Code, I had achieved far more than I had imagined. I realised that with good instructions and understanding, anything can be built this way. We don't need to fear security flaws or performance issues — as long as we instruct correctly. Old debates about languages and tech stacks are no longer as important. Java or C#, JavaScript frameworks — Python, Java or Kotlin, functional like F# or Scala? Pick something the team knows and that is widely used. The team doesn't need to be experts, but they need to understand the code. Now you ask AI to explain any differences from a language you know better — and you learn fast. **Coding is simply solved!**

## Precise instructions — the new code

As agents take responsibility for ever larger parts of the development cycle, our responsibility changes. What used to be code we wrote ourselves is now intentions and constraints we describe. For agents, precision is everything:

- Good instructions yield good results
- Vague instructions yield unpredictable behaviour

Providing precise descriptions of what to build, how to test it and what boundaries apply regarding security and compliance has become a core competency in modern development.

## Ready for the change?

Job postings ask for frontend, backend or fullstack developers. I've seen "AI developer" — what is that? If it sounds interesting, you'll read the job description anyway. We will surely see postings looking for "System Conductor", "AI Orchestrator" and the like, but I would probably read the "Experienced Developer" ad first. Because what really matters is the same as before: domain understanding, systems thinking and the ability to solve the right problems. Someone who knows the tools but lacks the big picture can build fast — but perhaps also in the wrong direction.

We are the same problem solvers, with the same experience and domain overview. What changes is the tools — and with them, what we spend our time on:

- Setting architecture, direction and standards
- Formulating precise instructions to agents
- Ensuring quality, security and traceability
- Solving problems agents cannot understand
- Assessing risk and consequences
- Making sure everything holds together in a robust system

> Agents give us speed. Experience gives them safety and direction.

## New arenas for sharing experience

But what about those who haven't yet had time to build up this experience? When agents write most of the code, new developers lose the natural learning arena that we had — writing code, making mistakes, debugging and gradually understanding systems from the inside. Domain understanding, systems thinking and the ability to ask the right questions don't come by themselves.

One answer many of us point to is **mob-instructing agents** — experienced and new developers sitting together and instructing agents as a group. Not like traditional pair programming where you share a keyboard, but as a collective exercise in thinking out loud: What should we ask the agent to do? Why this approach and not another? What should we test? What could go wrong? When new developers see how experienced developers formulate instructions, evaluate results and ask follow-up questions, they learn the way of thinking that code alone can no longer teach them.

## Roles must be redistributed

Throughout my career I have held many roles: developer, system architect, reviewer, test and quality lead, DevOps lead, IaC and CI/CD builder, and problem solver when complex bugs or hidden dependencies surfaced.

I enjoy challenges and happily take on tasks that are not *just* coding. Today, modern AI agents can take over much of the mechanical and repetitive work. Analysis, coding, documentation, pattern recognition and improvement suggestions happen in seconds.

> Imagine an agent instructed to check the logs and find the slowest API calls from the past week where there are more than a thousand calls. It looks at the code, creates a Pull Request with suggested changes where there is significant room for improvement, and notifies the team in a Slack channel. A task like that could easily take a developer half a day. The agent does it in minutes.

**That leaves the question: what is actually our job now?**

| Area | Agent handles | We must still own |
|------|--------------|-------------------|
| Code production | Generates code, tests and refactoring suggestions | Sets architecture, direction and quality level |
| Documentation | Writes drafts, connects information, summarises | Adds context, history and domain insight |
| CI/CD and IaC | Creates YAML files, Terraform suggestions and structures | Defines standards, security and governance |
| System architecture | Suggests patterns | Makes the decisions that require system understanding and experience |
| Problem solving | Analyses error messages and points to possible directions | Assesses priority, risk and the bigger picture |
| Quality and security | Suggests tests and controls | Owns the risk and the quality |

I have not seen a bigger change in how we work, or learned more new things, than in the last part of 2025 and the beginning of 2026. The developer role is not gone — it is simply redefined.

## Sources and inspiration

- [Preparing your team for agentic software development life cycle](https://www.thoughtworks.com/insights/articles/preparing-your-team-for-agentic-software-development-life-cycle) – ThoughtWorks
- [2026 Agentic Coding Trends Report](https://resources.anthropic.com/hubfs/2026%20Agentic%20Coding%20Trends%20Report.pdf) – Anthropic

---

*This article was put together in collaboration with Claude Code — instructed by me.*

*The photos in this article are not AI-generated, but taken from my own camera roll. The rainbow is from my hometown. The boat is one I used to walk past on my way to the train to work. It has since been "cleaned up", but it made sure I thought about technical debt every day. The cat is also real, and lives at home with me.*
