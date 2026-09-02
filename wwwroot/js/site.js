// Interaktion för sidhuvud, mobilmeny och scroll-animationer.

(function () {
    'use strict';

    /* ── Sidhuvud: dölj vid scroll ned, visa vid scroll upp ── */
    var header = document.querySelector('.site-header');
    if (header) {
        var lastY = window.scrollY;
        var ticking = false;

        var onScroll = function () {
            var y = window.scrollY;
            header.classList.toggle('is-scrolled', y > 8);

            var menuOpen = document.querySelector('.nav-links.is-open');
            header.classList.toggle('is-hidden', !menuOpen && y > lastY && y > 120);

            lastY = y;
            ticking = false;
        };

        window.addEventListener('scroll', function () {
            if (!ticking) {
                ticking = true;
                window.requestAnimationFrame(onScroll);
            }
        }, { passive: true });

        onScroll();
    }

    /* ── Mobilmeny ── */
    var toggle = document.querySelector('.nav-toggle');
    var links = document.getElementById('navLinks');
    if (toggle && links) {
        toggle.addEventListener('click', function () {
            var open = links.classList.toggle('is-open');
            toggle.setAttribute('aria-expanded', String(open));
        });

        links.addEventListener('click', function (e) {
            if (e.target.closest('a')) {
                links.classList.remove('is-open');
                toggle.setAttribute('aria-expanded', 'false');
            }
        });
    }

    /* ── Markera aktiv länk ── */
    var path = window.location.pathname.replace(/\/$/, '').toLowerCase() || '/';
    document.querySelectorAll('.nav-links > li > a').forEach(function (a) {
        var href = (a.getAttribute('href') || '').replace(/\/$/, '').toLowerCase() || '/';
        if (href === path) {
            a.classList.add('is-active');
        }
    });

    /* ── Scroll-animationer ── */
    var revealables = document.querySelectorAll('.reveal');
    if (revealables.length) {
        if (!('IntersectionObserver' in window)) {
            revealables.forEach(function (el) { el.classList.add('is-visible'); });
        } else {
            var observer = new IntersectionObserver(function (entries) {
                entries.forEach(function (entry) {
                    if (entry.isIntersecting) {
                        entry.target.classList.add('is-visible');
                        observer.unobserve(entry.target);
                    }
                });
            }, { threshold: 0.12, rootMargin: '0px 0px -8% 0px' });

            revealables.forEach(function (el, i) {
                el.style.transitionDelay = Math.min(i % 6, 5) * 70 + 'ms';
                observer.observe(el);
            });
        }
    }
})();
