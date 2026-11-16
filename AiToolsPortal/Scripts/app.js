// AI Nexus Portal - Interactive Application Scripts
document.addEventListener('DOMContentLoaded', function () {
    
    // --- 1. Dark / Light Theme Toggle ---
    const themeToggleBtn = document.getElementById('themeToggleBtn');
    const themeIcon = document.getElementById('themeIcon');
    const themeLabel = document.getElementById('themeLabel');
    const htmlElement = document.documentElement;

    const savedTheme = localStorage.getItem('ai_tools_theme') || 'dark';
    setTheme(savedTheme);

    if (themeToggleBtn) {
        themeToggleBtn.addEventListener('click', function () {
            const currentTheme = htmlElement.getAttribute('data-bs-theme');
            const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
            setTheme(newTheme);
        });
    }

    function setTheme(theme) {
        htmlElement.setAttribute('data-bs-theme', theme);
        localStorage.setItem('ai_tools_theme', theme);
        if (themeIcon) {
            themeIcon.className = theme === 'dark' ? 'bi bi-moon-stars-fill' : 'bi bi-sun-fill text-warning';
        }
        if (themeLabel) {
            themeLabel.textContent = theme === 'dark' ? 'Dark' : 'Light';
        }
    }

    // --- 2. Tab Navigation & Deep Linking ---
    // Handle tab switching buttons (e.g. from cards or table rows)
    document.querySelectorAll('.switch-to-tab-btn').forEach(button => {
        button.addEventListener('click', function (e) {
            e.preventDefault();
            const targetTabId = this.getAttribute('data-target-tab');
            const targetTabButton = document.getElementById(`tab-btn-${targetTabId}`);
            if (targetTabButton) {
                const tabTrigger = new bootstrap.Tab(targetTabButton);
                tabTrigger.show();
                window.scrollTo({ top: 0, behavior: 'smooth' });
                history.pushState(null, null, `?tab=${targetTabId}`);
            }
        });
    });

    // Update URL query param when a tab is clicked
    document.querySelectorAll('#aiToolsTabs button[data-bs-toggle="pill"]').forEach(tabBtn => {
        tabBtn.addEventListener('shown.bs.tab', function (event) {
            const targetId = event.target.getAttribute('data-bs-target').replace('#tab-', '');
            if (targetId) {
                history.pushState(null, null, `?tab=${targetId}`);
            }
        });
    });

    // Handle initial URL tab parameter or hash on load
    const urlParams = new URLSearchParams(window.location.search);
    const tabParam = urlParams.get('tab') || window.location.hash.replace('#', '').replace('tab-', '');
    if (tabParam) {
        const initialTabBtn = document.getElementById(`tab-btn-${tabParam}`);
        if (initialTabBtn) {
            const tabTrigger = new bootstrap.Tab(initialTabBtn);
            tabTrigger.show();
        }
    }

    // --- 3. Live Search & Category Filtering (Overview Tab) ---
    const searchInput = document.getElementById('liveSearchInput');
    const clearSearchBtn = document.getElementById('clearSearchBtn');
    const filterBtns = document.querySelectorAll('.filter-btn');
    const toolCards = document.querySelectorAll('.tool-grid-card');
    const noResultsState = document.getElementById('noResultsState');
    const resetFiltersBtn = document.getElementById('resetFiltersBtn');

    let currentCategory = 'all';
    let currentSearch = '';

    function applyFilters() {
        let visibleCount = 0;
        toolCards.forEach(card => {
            const cardCategory = card.getAttribute('data-category');
            const cardName = card.getAttribute('data-name');
            const cardDesc = card.getAttribute('data-desc');

            const matchesCategory = currentCategory === 'all' || cardCategory === currentCategory;
            const matchesSearch = !currentSearch || cardName.includes(currentSearch) || cardDesc.includes(currentSearch);

            if (matchesCategory && matchesSearch) {
                card.classList.remove('d-none');
                visibleCount++;
            } else {
                card.classList.add('d-none');
            }
        });

        if (noResultsState) {
            if (visibleCount === 0) {
                noResultsState.classList.remove('d-none');
            } else {
                noResultsState.classList.add('d-none');
            }
        }
    }

    if (searchInput) {
        searchInput.addEventListener('input', function () {
            currentSearch = this.value.trim().toLowerCase();
            applyFilters();
        });
    }

    if (clearSearchBtn) {
        clearSearchBtn.addEventListener('click', function () {
            if (searchInput) {
                searchInput.value = '';
                currentSearch = '';
                applyFilters();
            }
        });
    }

    filterBtns.forEach(btn => {
        btn.addEventListener('click', function () {
            filterBtns.forEach(b => {
                b.classList.remove('btn-outline-primary', 'active');
                b.classList.add('btn-outline-secondary');
            });
            this.classList.remove('btn-outline-secondary');
            this.classList.add('btn-outline-primary', 'active');

            currentCategory = this.getAttribute('data-filter');
            applyFilters();
        });
    });

    if (resetFiltersBtn) {
        resetFiltersBtn.addEventListener('click', function () {
            if (searchInput) searchInput.value = '';
            currentSearch = '';
            currentCategory = 'all';
            filterBtns.forEach((b, idx) => {
                if (idx === 0) {
                    b.classList.remove('btn-outline-secondary');
                    b.classList.add('btn-outline-primary', 'active');
                } else {
                    b.classList.remove('btn-outline-primary', 'active');
                    b.classList.add('btn-outline-secondary');
                }
            });
            applyFilters();
        });
    }

    // --- 4. Copy to Clipboard with Bootstrap Toast Feedback ---
    const toastElement = document.getElementById('copyToast');
    const toast = toastElement ? new bootstrap.Toast(toastElement, { delay: 2500 }) : null;

    document.querySelectorAll('.copy-btn').forEach(btn => {
        btn.addEventListener('click', function (e) {
            e.stopPropagation();
            const textToCopy = this.getAttribute('data-clipboard-text');
            if (textToCopy) {
                navigator.clipboard.writeText(textToCopy).then(() => {
                    if (toast) {
                        toast.show();
                    }
                }).catch(err => {
                    console.error('Failed to copy text: ', err);
                });
            }
        });
    });

});
