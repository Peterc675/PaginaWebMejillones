document.addEventListener('DOMContentLoaded', () => {
    // Modal Image Handling
    const directoryImages = document.querySelectorAll('[data-bs-target="#directoryImageModal"]');
    const directoryModalImage = document.getElementById('directoryModalImage');
    const directoryImageModal = new bootstrap.Modal(document.getElementById('directoryImageModal'));

    directoryImages.forEach(img => {
        img.addEventListener('click', (e) => {
            // Log for debugging
            console.log('Image clicked:', e.target);
            console.log('Image source:', e.target.src);

            // Set modal image source
            directoryModalImage.src = e.target.src;

            // Show the modal
            directoryImageModal.show();
        });
    });

    // Similar handling for confraternity images (if needed)
    const confraternityImages = document.querySelectorAll('[data-bs-target="#confraternityImageModal"]');
    const confraternityModalImage = document.getElementById('confraternityModalImage');
    const confraternityImageModal = new bootstrap.Modal(document.getElementById('confraternityImageModal'));

    confraternityImages.forEach(img => {
        img.addEventListener('click', (e) => {
            console.log('Confraternity Image clicked:', e.target);
            console.log('Confraternity Image source:', e.target.src);

            confraternityModalImage.src = e.target.src;
            confraternityImageModal.show();
        });
    });

    // Error checking
    window.addEventListener('error', (e) => {
        console.error('Error occurred:', e);
    });
});



document.addEventListener('DOMContentLoaded', () => {
    const galleryItems = document.querySelectorAll('.gallery-item');
    const lightboxModal = new bootstrap.Modal(document.getElementById('galleryModal'));
    const lightboxImage = document.querySelector('.lightbox-image');
    const lightboxYear = document.querySelector('.lightbox-year');
    const prevButton = document.getElementById('prevImage');
    const nextButton = document.getElementById('nextImage');

    let currentImageIndex = 0;
    const images = Array.from(galleryItems).map(item => ({
        src: item.querySelector('img').src,
        year: item.getAttribute('data-year')
    }));

    // Open Lightbox
    galleryItems.forEach((item, index) => {
        item.addEventListener('click', () => {
            currentImageIndex = index;
            updateLightbox();
            lightboxModal.show();
        });
    });

    // Update Lightbox Content
    function updateLightbox() {
        const currentImage = images[currentImageIndex];
        lightboxImage.src = currentImage.src;
        lightboxYear.textContent = `Año: ${currentImage.year}`;
        adjustImageSize();
    }

    // Adjust Image Size to Fit Screen
    function adjustImageSize() {
        const maxWidth = window.innerWidth * 0.9; // 90% of the viewport width
        const maxHeight = window.innerHeight * 0.9; // 90% of the viewport height

        // Temporarily hide the image to avoid flickering during adjustment
        lightboxImage.style.display = 'none';

        // Wait for the image to load before adjusting its size
        lightboxImage.onload = () => {
            const { naturalWidth, naturalHeight } = lightboxImage;

            // Calculate the aspect ratio
            const aspectRatio = naturalWidth / naturalHeight;

            // Adjust dimensions based on the aspect ratio
            if (naturalWidth > naturalHeight) {
                // Landscape image
                lightboxImage.style.width = `${Math.min(maxWidth, naturalWidth)}px`;
                lightboxImage.style.height = 'auto';
            } else {
                // Portrait image
                lightboxImage.style.height = `${Math.min(maxHeight, naturalHeight)}px`;
                lightboxImage.style.width = 'auto';
            }

            // Show the image after adjustment
            lightboxImage.style.display = 'block';
        };
    }

    // Navigation Buttons
    prevButton.addEventListener('click', () => {
        currentImageIndex = (currentImageIndex - 1 + images.length) % images.length;
        updateLightbox();
    });

    nextButton.addEventListener('click', () => {
        currentImageIndex = (currentImageIndex + 1) % images.length;
        updateLightbox();
    });

    // Keyboard Navigation
    document.addEventListener('keydown', (e) => {
        if (lightboxModal._isShown) {
            if (e.key === 'ArrowLeft') {
                currentImageIndex = (currentImageIndex - 1 + images.length) % images.length;
                updateLightbox();
            }
            if (e.key === 'ArrowRight') {
                currentImageIndex = (currentImageIndex + 1) % images.length;
                updateLightbox();
            }
            if (e.key === 'Escape') {
                lightboxModal.hide();
            }
        }
    });

    // Adjust image size on window resize
    window.addEventListener('resize', adjustImageSize);
});
