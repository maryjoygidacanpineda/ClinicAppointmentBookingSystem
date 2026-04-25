const API_BASE = "https://localhost:7000/api";

// DOM Elements
const elements = {
    fullName: document.getElementById("fullName"),
    birthdate: document.getElementById("birthdate"),
    age: document.getElementById("age"),
    gender: document.getElementById("gender"),
    contactInfo: document.getElementById("contactInfo"),
    disease: document.getElementById("disease"),
    bloodType: document.getElementById("bloodType"),
    allergies: document.getElementById("allergies"),
    medications: document.getElementById("medications"),
    doctorSelect: document.getElementById("doctorSelect"),
    appointmentDateTime: document.getElementById("appointmentDateTime"),
    paymentMethod: document.getElementById("paymentMethod")
};

// Navigation
function goToBooking() {
    document.getElementById("homePage").classList.add("hidden");
    document.getElementById("bookingPage").classList.remove("hidden");
    loadDoctors();
    document.body.scrollTop = 0;
}

function goHome() {
    document.getElementById("bookingPage").classList.add("hidden");
    document.getElementById("homePage").classList.remove("hidden");
}

// Load Doctors from Database
async function loadDoctors() {
    try {
        const response = await fetch(`${API_BASE}/doctors`);
        const doctors = await response.json();
        
        populateDoctorSelect(doctors);
    } catch (error) {
        console.warn('Using demo doctors:', error);
        populateDoctorSelect([
            { id: 1, name: "Dr. John Smith", specialty: "General Medicine" },
            { id: 2, name: "Dr. Sarah Johnson", specialty: "Cardiologist" },
            { id: 3, name: "Dr. Michael Chen", specialty: "Pediatrician" },
            { id: 4, name: "Dr. Emily Davis", specialty: "Dermatologist" },
            { id: 5, name: "Dr. David Wilson", specialty: "Orthopedist" }
        ]);
    }
}

// Populate Doctor Dropdown
function populateDoctorSelect(doctors) {
    elements.doctorSelect.innerHTML = '<option value="">Select Doctor</option>';
    
    doctors.forEach(doctor => {
        const option = document.createElement('option');
        option.value = doctor.id;
        option.textContent = `${doctor.name} - ${doctor.specialty}`;
        elements.doctorSelect.appendChild(option);
    });
}

// Auto-calculate Age
elements.birthdate.addEventListener("change", function() {
    if (this.value) {
        const birthDate = new Date(this.value);
        const today = new Date();
        let age = today.getFullYear() - birthDate.getFullYear();
        
        const monthDiff = today.getMonth() - birthDate.getMonth();
        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) {
            age--;
        }
        
        elements.age.value = age;
    }
});

// Submit Booking
async function confirmBooking() {
    // Validation
    const required = [elements.fullName, elements.doctorSelect, elements.appointmentDateTime];
    for (let field of required) {
        if (!field.value) {
            field.focus();
            alert(`Please fill: ${field.previousElementSibling?.textContent || 'Required field'}`);
            return;
        }
    }

    const appointmentData = {
        patientName: elements.fullName.value,
        birthdate: elements.birthdate.value,
        age: elements.age.value || 0,
        gender: elements.gender.value,
        contact: elements.contactInfo.value,
        disease: elements.disease.value,
        bloodType: elements.bloodType.value,
        allergies: elements.allergies.value,
        medications: elements.medications.value,
        doctorId: parseInt(elements.doctorSelect.value),
        appointmentDateTime: elements.appointmentDateTime.value,
        paymentMethod: elements.paymentMethod.value,
        status: "Scheduled"
    };

    try {
        const btn = event.target;
        btn.textContent = "Booking...";
        btn.disabled = true;

        const response = await fetch(`${API_BASE}/appointments`, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify(appointmentData)
        });

        if (response.ok) {
            alert("✅ Appointment booked successfully!\n\nConfirmation sent to your contact.");
            clearForm();
            goHome();
        } else {
            throw new Error("Server error");
        }
    } catch (error) {
        console.error(error);
        alert("❌ Booking failed. Please try again.");
    } finally {
        const btn = event.target;
        btn.textContent = "Submit";
        btn.disabled = false;
    }
}

function clearForm() {
    Object.values(elements).forEach(el => {
        if (el.tagName !== 'SELECT') el.value = '';
        else if (el.id !== 'paymentMethod') el.value = '';
    });
    elements.paymentMethod.value = 'Cash';
}

// Initialize
document.addEventListener('DOMContentLoaded', () => {
    const today = new Date().toISOString().split('T')[0];
    elements.appointmentDateTime.min = today;
});